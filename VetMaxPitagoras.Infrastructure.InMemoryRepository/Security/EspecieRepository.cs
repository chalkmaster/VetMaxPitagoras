using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetMaxPitagoras.Infrastructure.Security.Repository;
using VetMaxPitagoras.Infrastructure.Security.Entities;

namespace VetMaxPitagoras.Infrastructure.InMemoryRepository.Security
{
    public class EspecieRepository : Repository<Especie>, IEspecieRepository
    {
        private static List<Especie> _db;

        public Especie FindByName(string nome)
        {
            return GetMemoryDatabase().FirstOrDefault(especie => especie.Nome.ToLower().Equals(nome.ToString().ToLower()));
        }

        protected override List<Especie> GetMemoryDatabase()
        {
            return _db ?? (_db = new List<Especie>());
        }
    }
}
