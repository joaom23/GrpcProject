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
    public class GestoresService : Gestor.GestorBase
    {
        private readonly ILogger<GestoresService> _logger;

        private readonly ApplicationDbContext _context;

        public GestoresService(ILogger<GestoresService> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public override async Task RegistarChavesVencedora(RegistarChave request, IServerStreamWriter<RespostaVencedores> responseStream, ServerCallContext context)
        {
            //int[] arrayAuxNumeros = new int[] { request.Numero1, request.Numero2, request.Numero3, request.Numero4, request.Numero5 };
            //Array.Sort(arrayAuxNumeros);

            //int[] arrayAuxEstrelas = new int[] { request.Estrela1, request.Estrela2 };
            //Array.Sort(arrayAuxEstrelas);


            ICollection<Aposta> vencedores1 = _context.Apostas.Include(x => x.Numeros).Include(x => x.Estrelas).Where(x => x.Numeros.Numero1 == request.Numero1 && x.Numeros.Numero2 == request.Numero2 && x.Numeros.Numero3 == request.Numero3 && x.Numeros.Numero4 == request.Numero4 && x.Numeros.Numero5 == request.Numero5 && x.Estrelas.Estrela1 == request.Estrela1 && x.Estrelas.Estrela2 == request.Estrela2 && x.Ativa == true).ToList();

            ICollection<Aposta> vencedores2 = _context.Apostas.Include(x => x.Numeros).Include(x => x.Estrelas).Where(x => x.Numeros.Numero1 == request.Numero1 && x.Numeros.Numero2 == request.Numero2 && x.Numeros.Numero3 == request.Numero3 && x.Numeros.Numero4 == request.Numero4 && x.Numeros.Numero5 == request.Numero5 && ((x.Estrelas.Estrela1 != request.Estrela1 && x.Estrelas.Estrela2 == request.Estrela2) || (x.Estrelas.Estrela1 == request.Estrela1 && x.Estrelas.Estrela2 != request.Estrela2)) && x.Ativa == true).ToList();

            ICollection<Aposta> vencedores3 = _context.Apostas.Include(x => x.Numeros).Include(x => x.Estrelas).Where(x => x.Numeros.Numero1 == request.Numero1 && x.Numeros.Numero2 == request.Numero2 && x.Numeros.Numero3 == request.Numero3 && x.Numeros.Numero4 == request.Numero4 && x.Numeros.Numero5 == request.Numero5 && (x.Estrelas.Estrela1 != request.Estrela1 && x.Estrelas.Estrela2 != request.Estrela2) && x.Ativa == true).ToList();



            List<RespostaVencedores> listaChavesvencedores = new List<RespostaVencedores>();

            foreach (var a in vencedores1)
            {
                RespostaVencedores chavesvencedora = new RespostaVencedores
                {
                    Nome = a.UserName,
                    Numero1 = a.Numeros.Numero1,
                    Numero2 = a.Numeros.Numero2,
                    Numero3 = a.Numeros.Numero3,
                    Numero4 = a.Numeros.Numero4,
                    Numero5 = a.Numeros.Numero5,
                    Estrela1 = a.Estrelas.Estrela1,
                    Estrela2 = a.Estrelas.Estrela2,
                    DataAposta = Timestamp.FromDateTimeOffset(a.DataAposta.Date),  /*Timestamp.FromDateTime(a.DataAposta);*/
                    Premio = 1
                };
                listaChavesvencedores.Add(chavesvencedora);
            }

            foreach (var a in vencedores2)
            {
                RespostaVencedores chavesvencedora = new RespostaVencedores
                {
                    Nome = a.UserName,
                    Numero1 = a.Numeros.Numero1,
                    Numero2 = a.Numeros.Numero2,
                    Numero3 = a.Numeros.Numero3,
                    Numero4 = a.Numeros.Numero4,
                    Numero5 = a.Numeros.Numero5,
                    Estrela1 = a.Estrelas.Estrela1,
                    Estrela2 = a.Estrelas.Estrela2,
                    DataAposta = Timestamp.FromDateTimeOffset(a.DataAposta.Date),  /*Timestamp.FromDateTime(a.DataAposta);*/
                    Premio = 2
                };
                listaChavesvencedores.Add(chavesvencedora);
            }

            foreach (var a in vencedores3)
            {
                RespostaVencedores chavesvencedora = new RespostaVencedores
                {
                    Nome = a.UserName,
                    Numero1 = a.Numeros.Numero1,
                    Numero2 = a.Numeros.Numero2,
                    Numero3 = a.Numeros.Numero3,
                    Numero4 = a.Numeros.Numero4,
                    Numero5 = a.Numeros.Numero5,
                    Estrela1 = a.Estrelas.Estrela1,
                    Estrela2 = a.Estrelas.Estrela2,
                    DataAposta = Timestamp.FromDateTimeOffset(a.DataAposta.Date),  /*Timestamp.FromDateTime(a.DataAposta);*/
                    Premio = 3
                };
                listaChavesvencedores.Add(chavesvencedora);
            }

            foreach (var chave in listaChavesvencedores)
            {
                await responseStream.WriteAsync(chave);
            }

        }

        public override Task<GestorMensagem> VerificaEntradaGestor(GestorIdentidade request, ServerCallContext context)
        {
            GestorMensagem msgestor = new GestorMensagem
            {
                Mensagem = "Bem-vindo!!"
            };
            return Task.FromResult(msgestor);
        }
    }
}
