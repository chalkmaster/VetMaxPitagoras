using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetMaxPitagoras.Core.Entities;

namespace VetMaxPitagoras.Infrastructure.Security.Entities
{
    public class Funcionario : Entity
    {
        public string Nome { get; set; }
        public DateTime datanascimento { get; set; }
        public int idade { get; set; }
        public string funcao { get; set; }
        public string cargo { get; set; }
        public string departamento { get; set; }
        public double telefone { get; set; }
        public Endereco endereco { get; set; }
        public string email { get; set; }
        public string permissão { get; set; }
    }
}