using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetMaxPitagoras.Core.Entities;

namespace VetMaxPitagoras.Infrastructure.Security.Entities
{
    public class Especie : Entity
    {
        public Especie()
        {

        }

        public Especie(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }

        //nome da especie   
        public string Nome { get; set; }
    }
}
