using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetMaxPitagoras.Core.Entities;

namespace VetMaxPitagoras.Infrastructure.Security.Entities
{
    public class Endereco : Entity
    {
        public string rua { get; set; }
        public string cidade { get; set; }
        public string bairro { get; set; }
        public int numero { get; set; }
        public double cep { get; set; }
    }
}
