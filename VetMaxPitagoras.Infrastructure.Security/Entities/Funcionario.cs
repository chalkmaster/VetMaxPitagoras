﻿using System;
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
        public string cargo { get; set; }
        public string departamento { get; set; }
        public DateTime datanascimento { get; set; }
        public string telefone { get; set; }
        public string endereco { get; set; }
        public string email { get; set; }
        public string especialidade { get; set; }
        public string titulacao { get; set; }
    }
}