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
        //Nome da raça
        public string NomeRaça { get; set; }
        public string Cor { get; set; }

    }

}
