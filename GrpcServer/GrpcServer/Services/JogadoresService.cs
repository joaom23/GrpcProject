using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using GrpcServer.Data;
using GrpcServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServer.Services
{
    public class JogadoresService : Jogador.JogadorBase
    {
        private readonly ILogger<JogadoresService> _logger;

        private readonly ApplicationDbContext _context;


        public JogadoresService(ILogger<JogadoresService> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public override Task<JogadorResultadoAposta> RecebeApostaChave(JogadorAposta request, ServerCallContext context)
        {
            int[] arrayAuxNumeros = new int[] { request.Numero1, request.Numero2, request.Numero3, request.Numero4, request.Numero5 };
            Array.Sort(arrayAuxNumeros);

            int[] arrayAuxEstrelas = new int[] { request.Estrela1, request.Estrela2 };
            Array.Sort(arrayAuxEstrelas);

            Numeros n = new Numeros
            {
                Numero1 = arrayAuxNumeros[0],
                Numero2 = arrayAuxNumeros[1],
                Numero3 = arrayAuxNumeros[2],
                Numero4 = arrayAuxNumeros[3],
                Numero5 = arrayAuxNumeros[4]
            };

            _context.Numeros.Add(n);
            _context.SaveChanges();

            Estrelas e = new Estrelas
            {
                Estrela1 = arrayAuxEstrelas[0],
                Estrela2 = arrayAuxEstrelas[1]
            };

            _context.Estrelas.Add(e);
            _context.SaveChanges();

            Aposta aposta = new Aposta
            {
                UserName = request.Nome,
                NumerosId = n.Id,
                EstrelasId = e.Id,
                DataAposta = DateTime.Now.AddDays(1),
                Ativa = true
            };

            _context.Apostas.Add(aposta);
            _context.SaveChanges();

            JogadorResultadoAposta msg = new JogadorResultadoAposta
            {
                Mensagem = "Aposta realizada com sucesso"
            };

            return Task.FromResult(msg);
        }
        public override async Task VerApostas(JogadorDados request, IServerStreamWriter<JogadorChavesAnteriores> responseStream, ServerCallContext context)
        {

            ICollection<Aposta> aposta = _context.Apostas.Include(x => x.Numeros).Include(x => x.Estrelas).Where(x => x.UserName == request.Nome).OrderByDescending(x=>x.DataAposta).ToList();

            List<JogadorChavesAnteriores> listaChavesAnteriores = new List<JogadorChavesAnteriores>();

            foreach (var a in aposta)
            {
                JogadorChavesAnteriores chavesAnterior = new JogadorChavesAnteriores
                {
                    Numero1 = a.Numeros.Numero1,
                    Numero2 = a.Numeros.Numero2,
                    Numero3 = a.Numeros.Numero3,
                    Numero4 = a.Numeros.Numero4,
                    Numero5 = a.Numeros.Numero5,
                    Estrela1 = a.Estrelas.Estrela1,
                    Estrela2 = a.Estrelas.Estrela2,
                    DataAposta = Timestamp.FromDateTimeOffset(a.DataAposta.Date)  /*Timestamp.FromDateTime(a.DataAposta);*/
                };
                listaChavesAnteriores.Add(chavesAnterior);
            }

            foreach(var chave in listaChavesAnteriores)
            {
                await responseStream.WriteAsync(chave);
            }
        }

        public override Task<JogadorMensagem> VerificaEntrada(JogadorIdentidade request, ServerCallContext context)
        {
            JogadorMensagem msgs = new JogadorMensagem
            {
                Mensagem = "Bem-Vindo!"
            };

            return Task.FromResult(msgs);
        }

    }
}
