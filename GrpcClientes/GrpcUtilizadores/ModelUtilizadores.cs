using GrpcClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrpcUtilizadores
{
    public class ModelUtilizadores
    {
        public event UmaString RespostaEntrarUtilizador;
        public event UmaString RespostaRegistarAposta;
        public event ListaChavesUmInt RespostaChavesAnteriores;

        //public void EnviaRespostChavesAnteriores(string s)
        //{
        //    if (RespostaChavesAnteriores != null)
        //    {
        //        RespostaChavesAnteriores(s);
        //    }
        //}

        public void EnviaRespostEntrarUtilizador(string s)
        {
            if (RespostaEntrarUtilizador != null)
            {
                RespostaEntrarUtilizador(s);
            }
        }

        public void EnviaRespostaRegistarAposta(string s)
        {
            if (RespostaRegistarAposta != null)
            {
                RespostaRegistarAposta(s);
            }
        }

        public void EnviaRespostChavesAnteriores(List<JogadorChavesAnteriores> apostas, int numero)
        {
            if (RespostaChavesAnteriores != null)
            {
                RespostaChavesAnteriores(apostas, numero);
            }
        }
    }

}
