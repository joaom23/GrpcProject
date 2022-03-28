using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GrpcServer.Models
{
    public partial class Aposta
    {
        [Key]
        public int Id { get; set; }
        public int NumerosId { get; set; }
        public Numeros Numeros { get; set; }
        public int EstrelasId { get; set; }
        public Estrelas Estrelas { get; set; }
        public DateTime DataAposta { get; set; }    
        public string UserName { get; set; }
2 
        public bool Ativa { get; set; }
    }
}
