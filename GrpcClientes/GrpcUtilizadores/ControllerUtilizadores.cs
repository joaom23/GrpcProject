using Grpc.Core;
using Grpc.Net.Client;
using GrpcClient;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static GrpcClient.Jogador;

namespace GrpcUtilizadores
{
    public class ControllerUtilizadores
    {

        public Jogador.JogadorClient Cliente { get; set; }

        public ControllerUtilizadores()
        {
            Program.V_Entrar.EntrarUtilizador += V_Entrar_EntrarUtilizador;
            Program.V_RegistarAposta.RegistarAposta += V_RegistarAposta_RegistarAposta;
            Program.V_ChavesAnteriores.ApresentarChavesAnteriores += V_ChavesAnteriores_ApresentarChavesAnteriores;  
        }

        private async void V_ChavesAnteriores_ApresentarChavesAnteriores(string Username)
        {
            var httpHandler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback =
                HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };

            //var channel = GrpcChannel.ForAddress("https://localhost:5001", new GrpcChannelOptions { HttpHandler = httpHandler });
            var channel = GrpcChannel.ForAddress("https://25.78.63.178:5001", new GrpcChannelOptions { HttpHandler = httpHandler });
            var client = new JogadorClient(channel);

            JogadorDados jogador = new JogadorDados
            {
                Nome = Username
            };

            List<JogadorChavesAnteriores> apostas = new List<JogadorChavesAnteriores>();

            using (var response = client.VerApostas(jogador))
            {
                while (await response.ResponseStream.MoveNext())
                {
                    var currentBet = response.ResponseStream.Current;
                    apostas.Add(currentBet);
                }
            }
            Program.M_Utilizadores.EnviaRespostChavesAnteriores(apostas, apostas.Count);

        }

        public void V_RegistarAposta_RegistarAposta(string User, int Numero1, int Numero2, int Numero3, int Numero4, int Numero5, int Estrela1, int Estrela2)
        {
            var httpClientHandler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback =
                HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };

            //var channel = GrpcChannel.ForAddress("https://localhost:5001", new GrpcChannelOptions { HttpHandler = httpClientHandler });
            var channel = GrpcChannel.ForAddress("https://25.78.63.178:5001", new GrpcChannelOptions { HttpHandler = httpClientHandler });
            var client = new JogadorClient(channel);

            JogadorAposta aposta = new JogadorAposta
            {
                Nome = User,
                Numero1 = Numero1,
                Numero2 = Numero2,
                Numero3 = Numero3,
                Numero4 = Numero4,
                Numero5 = Numero5,
                Estrela1 = Estrela1,
                Estrela2 = Estrela2
            };

            var response = client.RecebeApostaChave(aposta);

            Program.M_Utilizadores.EnviaRespostaRegistarAposta(response.Mensagem);

        }

        private void V_Entrar_EntrarUtilizador(string s1, int s2)
        {
            var httpClientHandler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback =
                HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };
            var httpClient = new HttpClient(httpClientHandler);

            // The port number(5001) must match the port of the gRPC server.
            var channel = GrpcChannel.ForAddress("https://25.78.63.178:5001", new GrpcChannelOptions { HttpHandler = httpClientHandler });
            //var channel = GrpcChannel.ForAddress("https://localhost:5001", new GrpcChannelOptions { HttpClient = httpClient });

            var client = new JogadorClient(channel);

            JogadorIdentidade ji = new JogadorIdentidade
            {
                Nome = s1,
                Idade = s2
            };

            var resposta = client.VerificaEntrada(ji);

            Program.M_Utilizadores.EnviaRespostEntrarUtilizador(resposta.Mensagem);
        }
    }
}
