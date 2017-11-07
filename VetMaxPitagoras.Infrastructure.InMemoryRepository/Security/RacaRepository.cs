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

        public RacaRepository()
        {
            PopularDadosEstaticosTemporariamente();
        }

       public Raca FindByRaca(string raca)
        {
            return GetMemoryDatabase().FirstOrDefault(r => r.NomeRaça.ToLower().Equals(raca.ToString().ToLower()));
        } 

        protected override List<Raca> GetMemoryDatabase()
        {
            return _db ?? (_db = new List<Raca>());
        }

        private void PopularDadosEstaticosTemporariamente()
        {
            _db = new List<Raca>();
            string[] racas = {"Vira-lata", "Poodle", "Buldogue", "Pastor", "Pitbull", "Pincher" };

            for (var i = 0; i < racas.Length; i++)
            {
                Raca r = new Raca(i + 1, racas[i]);
                _db.Add(r);
            }
        }
    }
}
