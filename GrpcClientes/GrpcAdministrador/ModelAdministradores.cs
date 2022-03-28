using GrpcClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrpcAdministrador
{
    public class ModelAdministradores
    {
        public event ListaChavesUmInt ReceberChavesAtivas;
        public event UmaString RespostaArquivarEnovoSorteio;
        public event UmaString RespostaEntrarAdmnistrador;

        public void EnviarRepostaEntrarAdmnistrador(string s)
        {
            RespostaEntrarAdmnistrador(s);
        }

        public void EnviarRespostaArquivarEnovoSorteio(string s)
        {
            RespostaArquivarEnovoSorteio(s);
        }


        public void ShowChavesAtivas(List<RespostaVisualizarApostas> apostas, int numero)
        {
            if (ReceberChavesAtivas != null)
            {
                ReceberChavesAtivas(apostas, numero);
            }
        }

    }
}
