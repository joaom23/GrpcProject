using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Grpc.Net.Client;
using GrpcClient;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using static GrpcClient.Administrador;

namespace GrpcAdministrador
{
    public class ControllerAdministrador
    {

        public ControllerAdministrador()
        {
            Program.V_Menu.ArquivarComecarNovoSorteio += V_Menu_ArquivarComecarNovoSorteio;
            Program.V_ChavesAtivas.PedirChavesAtivas += V_ChavesAtivas_PedirChavesAtivas;
            Program.V_Entrar.EntradaAdmnistrador += V_Entrar_EntradaAdmnistrador;
        }

        private void V_Entrar_EntradaAdmnistrador(string s)
        {
            var httpClientHandler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback =
                HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };
            //var httpClient = new HttpClient(httpClientHandler);

            var channel = GrpcChannel.ForAddress("https://25.78.63.178:5001", new GrpcChannelOptions { HttpHandler = httpClientHandler });
            //var channel = GrpcChannel.ForAddress("https://localhost:5001", new GrpcChannelOptions { HttpHandler = httpClientHandler });
            var client = new AdministradorClient(channel);

            AdmnistradorIdentidade adi = new AdmnistradorIdentidade
            {
                Nome = s
            };

            var resposta = client.VerificaEntradaAdmnistrador(adi);

            Program.M_Administradores.EnviarRepostaEntrarAdmnistrador(resposta.Mensagem);
        }

        private void V_Menu_ArquivarComecarNovoSorteio()
        {
            var httpHandler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback =
                HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };

            //var channel = GrpcChannel.ForAddress("https://localhost:5001", new GrpcChannelOptions { HttpHandler = httpHandler });
            var channel = GrpcChannel.ForAddress("https://25.78.63.178:5001", new GrpcChannelOptions { HttpHandler = httpHandler });
            var client = new AdministradorClient(channel);

            var response = client.ArquivarChaves(new ArquivarVazio());

            Program.M_Administradores.EnviarRespostaArquivarEnovoSorteio(response.Mensagem);
        }

        private async void V_ChavesAtivas_PedirChavesAtivas()
        {
            var httpHandler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback =
                HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };

            //var channel = GrpcChannel.ForAddress("https://localhost:5001", new GrpcChannelOptions { HttpHandler = httpHandler });
            var channel = GrpcChannel.ForAddress("https://25.78.63.178:5001", new GrpcChannelOptions { HttpHandler = httpHandler });
            var client = new AdministradorClient(channel);

            List<RespostaVisualizarApostas> apostas = new List<RespostaVisualizarApostas>();

            using (var response = client.VisualizarChaves(new VisualizarVazio()))
            {
                while (await response.ResponseStream.MoveNext())
                {
                    var currentBet = response.ResponseStream.Current;
                    apostas.Add(currentBet);
                }
            }

            Program.M_Administradores.ShowChavesAtivas(apostas, apostas.Count);
        }         
    }
}
