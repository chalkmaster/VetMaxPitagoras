using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetMaxPitagoras.Infrastructure.Security.Entities;
using VetMaxPitagoras.Core.Repository;
using VetMaxPitagoras.Infrastructure.Security.Repository;

namespace VetMaxPitagoras.Infrastructure.InMemoryRepository.Security
{
    public class AnimalRepository : Repository<Animal>, IAnimalRepository
    {

        private static List<Animal> _db;
         
        public Animal FindByUserName(string nome)
        {
            return GetMemoryDatabase().FirstOrDefault(animal => animal.Nome.ToLower() == nome.ToLower());
        }

        protected override List<Animal> GetMemoryDatabase()
        {
            return _db ?? (_db = new List<Animal>());
        }
    }
}

