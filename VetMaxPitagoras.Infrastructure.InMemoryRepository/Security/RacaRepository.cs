using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetMaxPitagoras.Infrastructure.Security.Entities;
using VetMaxPitagoras.Infrastructure.Security.Repository;

namespace VetMaxPitagoras.Infrastructure.InMemoryRepository.Security
{
    public class RacaRepository : Repository<Raca>, IRacaRepository
    {
        private static List<Raca> _db;

        public Raca FindByRaca(string raca)
        {
            return GetMemoryDatabase().FirstOrDefault(rs => rs.Nome.ToLower().Equals(raca.ToString().ToLower()));
        }

        protected override List<Raca> GetMemoryDatabase()
        {
            return _db ?? (_db = new List<Raca>());
        }
    }
}
