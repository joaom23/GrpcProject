using GrpcClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrpcUtilizadores
{
    public delegate void StringInt (string s1, int s2);
    public delegate void UmaString(string s);
    public delegate void ListaChavesUmInt(List<JogadorChavesAnteriores> apostas, int num);
    public delegate void StringSeisInt (string User,int Numero1, int Numero2, int Numero3, int Numero4, int Numero5, int Estrela1, int Estrela2);
    public delegate void SeteInts(int Numero1, int Numero2, int Numero3, int Numero4, int Numero5, int Estrela1, int Estrela2);

}
