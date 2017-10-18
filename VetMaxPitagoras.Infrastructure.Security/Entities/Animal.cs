using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetMaxPitagoras.Core.Entities;

namespace VetMaxPitagoras.Infrastructure.Security.Entities
{
    public class Animal : Entity
    {
        public string Nome { get; set; }
        public string Raça { get; set; }
        public string NomeDono { get; set; }
        public string TelefoneDono { get; set; }
        public string TelefoneTipo { get; set; }
    }
}
