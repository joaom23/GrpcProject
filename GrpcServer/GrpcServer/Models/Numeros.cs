using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServer.Models
{
    public partial class Numeros
    {
        public int Id { get; set; }
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }
        public int Numero3 { get; set; }
        public int Numero4 { get; set; }
        public int Numero5 { get; set; }
        public ICollection<Aposta> Apostas { get; set; }

    }
}
