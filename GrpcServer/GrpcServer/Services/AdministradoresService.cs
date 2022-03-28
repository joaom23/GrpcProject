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
    public class AdministradoresService : Administrador.AdministradorBase
    {
        private readonly ILogger<AdministradoresService> _logger;
        private readonly ApplicationDbContext _context;
        public AdministradoresService(ILogger<AdministradoresService> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public override async Task VisualizarChaves(VisualizarVazio request, IServerStreamWriter<RespostaVisualizarApostas> responseStream, ServerCallContext context)
        {

            IList<Aposta> apostaAtivas = _context.Apostas.Include(x => x.Numeros).Include(x => x.Estrelas).Where(x => x.Ativa == true).OrderByDescending(x => x.DataAposta).ToList();

            List<RespostaVisualizarApostas> listaApostasAtivas = new List<RespostaVisualizarApostas>();

            foreach (var a in apostaAtivas)
            {
                RespostaVisualizarApostas ApostasAtivas = new RespostaVisualizarApostas();
                ApostasAtivas.Nomes = a.UserName;
                ApostasAtivas.Numero1 = a.Numeros.Numero1;
                ApostasAtivas.Numero2 = a.Numeros.Numero2;
                ApostasAtivas.Numero3 = a.Numeros.Numero3;
                ApostasAtivas.Numero4 = a.Numeros.Numero4;
                ApostasAtivas.Numero5 = a.Numeros.Numero5;
                ApostasAtivas.Estrela1 = a.Estrelas.Estrela1;
                ApostasAtivas.Estrela2 = a.Estrelas.Estrela2;
                ApostasAtivas.DataAposta = Timestamp.FromDateTimeOffset(a.DataAposta.Date);  /*Timestamp.FromDateTime(a.DataAposta);*/
                listaApostasAtivas.Add(ApostasAtivas);
            }

            foreach (var chave in listaApostasAtivas)
            {
                await responseStream.WriteAsync(chave);
            }
        }

        public override Task<ArquivarMensagem> ArquivarChaves(ArquivarVazio request, ServerCallContext context)
        {
            IList<Aposta> apostas = _context.Apostas.Include(x => x.Numeros).Include(x => x.Estrelas).Where(x => x.Ativa == true).OrderByDescending(x => x.DataAposta).ToList();

            foreach (var aposta in apostas)
            {
                  aposta.Ativa = false;
                 _context.Update(aposta);
                 _context.SaveChanges();
            }

            ArquivarMensagem msg = new ArquivarMensagem();
            msg.Mensagem = "Apostas arquivadas com sucesso!";

            return Task.FromResult(msg);
        }

        public override Task<AdmnistradorMensagem> VerificaEntradaAdmnistrador(AdmnistradorIdentidade request, ServerCallContext context)
        {
            AdmnistradorMensagem admsg = new AdmnistradorMensagem();
            admsg.Mensagem = "Bem-vindo!";

            return Task.FromResult(admsg);
        }

    }
}
