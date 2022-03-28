using GrpcClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrpcGestao
{
    public class ModelGestao
    {
        public event UmaString RespostaEntrarGestor;
        public event ListaChavesVencedores RespostaRegistarChaves;

        public void EnviaRespostRegistarChaves(List<RespostaVencedores> vencedores,int numero)
        {
            if (RespostaRegistarChaves != null)
            {
                RespostaRegistarChaves(vencedores, numero);
            }
        }

        public void EnviaRespostaEntrarGestor(string s)
        {
            RespostaEntrarGestor(s);
        }



    }
}
