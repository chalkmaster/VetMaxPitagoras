using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetMaxPitagoras.Core.Entities;

namespace VetMaxPitagoras.Infrastructure.Security.Entities
{
    public class Raca : Entity
    {
        public Raca()
        {

        }

        public Raca(int id, string nomeRaca) : this(id, nomeRaca, string.Empty)
        {           
        }

        public Raca(int id, string nomeRaca, string cor)
        {
            this.Id = id;
            this.NomeRaça = nomeRaca;
            this.Cor = cor;
        }
       
        //Nome da raça
        public string NomeRaça { get; set; }
        public string Cor { get; set; }

    }

}
