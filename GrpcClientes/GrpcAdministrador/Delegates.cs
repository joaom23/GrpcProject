using GrpcClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrpcAdministrador
{
    public delegate void StringInt (string s1, int s2);
    public delegate void UmaString(string s);
    public delegate void StringSeisInt (string User,int Numero1, int Numero2, int Numero3, int Numero4, int Numero5, int Estrela1, int Estrela2);
    public delegate void Vazio();
    public delegate void ListaChavesUmInt(List<RespostaVisualizarApostas> Visapostas, int num);
}
