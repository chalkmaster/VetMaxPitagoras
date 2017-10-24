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
         
        public List<Animal> FindByName(string nome)
        {
            return GetMemoryDatabase().FindAll(animal => animal.Nome.ToLower().Equals(nome.ToLower()));
        }

        public List<Animal> FindByProprietarioName(string nome)
        {
            return GetMemoryDatabase().FindAll(animal => animal.Nome.ToLower().Equals(nome.ToLower()));
        }

        protected override List<Animal> GetMemoryDatabase()
        {
            return _db ?? (_db = new List<Animal>());
        }
    }
}