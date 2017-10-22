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
        public Especie Especie { get; set; }
        public Raca Raca { get; set; }
        public User Proprietario { get; set; }


        //  criado só para funcionar a validação de dados se necessario mude.  
        public string NomeDono { get; set; }
        public string Raça { get; set; }
        public string TelefoneDono { get; set; }
        public string TelefoneTipo { get; set; }
        // criado só para funcionar a validação de dados se necessario mude.  

        Especie especie1 = new Especie();
        especie1.Nome = "Cão";
        especie.Raca = "Pastor Alemão";
    }

    List<Animal> myList = new List<Animal>()
    {
        new Animal = { Nome = }
    }

    
}
