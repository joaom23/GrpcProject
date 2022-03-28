using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServer.Models
{
    public partial class Estrelas
    {
        [Key]
        public int Id { get; set; }
        public int Estrela1 { get; set; }
        public int Estrela2 { get; set; }
        public ICollection<Aposta> Apostas { get; set; }
    }
}
