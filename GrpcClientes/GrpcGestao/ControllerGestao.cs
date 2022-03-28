using Grpc.Core;
using Grpc.Net.Client;
using GrpcClient;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using static GrpcClient.Gestor;

namespace GrpcGestao
{
    public class ControllerGestao
    {

        public ControllerGestao()
        {
            Program.V_Home.EntradaGestor += V_Home_EntradaGestor;
            Program.V_RegistarChaveVencedora.RegistarChavesVencedora += V_RegistarChaveVencedora_RegistarChavesVencedora;
        }

        private async void V_RegistarChaveVencedora_RegistarChavesVencedora(int Numero1, int Numero2, int Numero3, int Numero4, int Numero5, int Estrela1, int Estrela2)
        {
            var httpClientHandler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback =
                HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };
            //var httpClient = new HttpClient(httpClientHandler);
            var channel = GrpcChannel.ForAddress("https://25.78.63.178:5001", new GrpcChannelOptions { HttpHandler = httpClientHandler });
            //var channel = GrpcChannel.ForAddress("https://localhost:5001", new GrpcChannelOptions { HttpHandler = httpClientHandler });
            var client = new GestorClient(channel);

            List<RespostaVencedores> vencedores = new List<RespostaVencedores>();

            RegistarChave registarchave = new RegistarChave
            {
                Numero1 = Numero1,
                Numero2 = Numero2,
                Numero3 = Numero3,
                Numero4 = Numero4,
                Numero5 = Numero5,
                Estrela1 = Estrela1,
                Estrela2 = Estrela2
            };

            using (var response = client.RegistarChavesVencedora(registarchave))
            {
                while (await response.ResponseStream.MoveNext())
                {
                    var currentBet = response.ResponseStream.Current;
                    vencedores.Add(currentBet);
                }
            }

            //var response = client.RegistarChavesVencedora(registarchave);

            Program.M_Gestao.EnviaRespostRegistarChaves(vencedores, vencedores.Count);
        }

        private void V_Home_EntradaGestor(string s)
        {
            var httpClientHandler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback =
                HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };
            //var httpClient = new HttpClient(httpClientHandler);
            var channel = GrpcChannel.ForAddress("https://25.78.63.178:5001", new GrpcChannelOptions { HttpHandler = httpClientHandler });
            //var channel = GrpcChannel.ForAddress("https://localhost:5001", new GrpcChannelOptions { HttpHandler = httpClientHandler });
            var client = new GestorClient(channel);

            GestorIdentidade gi = new GestorIdentidade
            {
                Nome = s
            };

            var resposta = client.VerificaEntradaGestor(gi);

            Program.M_Gestao.EnviaRespostaEntrarGestor(resposta.Mensagem);
        }

    }
}
