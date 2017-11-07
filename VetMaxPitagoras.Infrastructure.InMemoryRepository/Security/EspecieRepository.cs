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

        public EspecieRepository()
        {
            PopularDadosEstaticosTemporariamente();
        }

        public Especie FindByName(string nome)
        {
            return GetMemoryDatabase().FirstOrDefault(especie => especie.Nome.ToLower().Equals(nome.ToString().ToLower()));
        }

        protected override List<Especie> GetMemoryDatabase()
        {
            return _db ?? (_db = new List<Especie>());
        }

        
        private void PopularDadosEstaticosTemporariamente()
        {
            _db = new List<Especie>();
            string[] especies = { "Cachorro", "Gato", "Pássaro", "Porquinho", "Ranmster" };

            for(var i = 0; i < especies.Length; i++)
            {
                Especie e = new Especie(i + 1, especies[i]);
                _db.Add(e);
            }
        }
    }
}
