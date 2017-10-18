using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetMaxPitagoras.Infrastructure.Security.Entities;
<<<<<<< HEAD
using VetMaxPitagoras.Core.Repository;
=======
>>>>>>> original
using VetMaxPitagoras.Infrastructure.Security.Repository;

namespace VetMaxPitagoras.Infrastructure.InMemoryRepository.Security
{
    public class AnimalRepository : Repository<Animal>, IAnimalRepository
    {
<<<<<<< HEAD

        private static List<Animal> _db;
         
        public Animal FindByUserName(string nome)
        {
            return GetMemoryDatabase().FirstOrDefault(animal => animal.Nome.ToLower() == nome.ToLower());
=======
        private static List<Animal> _db;

        public List<Animal> FindByName(string nome)
        {
            return GetMemoryDatabase().FindAll(animal => animal.Nome.ToLower().Equals(nome.ToLower()));
        }

        public List<Animal> FindByProprietarioName(string nome)
        {
            return GetMemoryDatabase().FindAll(animal => animal.Nome.ToLower().Equals(nome.ToLower()));
>>>>>>> original
        }

        protected override List<Animal> GetMemoryDatabase()
        {
            return _db ?? (_db = new List<Animal>());
        }
    }
}
<<<<<<< HEAD

=======
>>>>>>> original
