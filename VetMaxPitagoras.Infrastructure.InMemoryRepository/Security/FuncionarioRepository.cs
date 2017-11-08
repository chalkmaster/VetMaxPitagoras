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
    public class FuncionarioRepository : Repository<Funcionario>, IFuncionarioRepository
    {
        private static List<Funcionario> _db;

        public List<Funcionario> FindByName(string nome)
        {
            return GetMemoryDatabase().FindAll(Funcionario => Funcionario.Nome.ToLower().Equals(nome.ToLower()));
        }

        public List<Funcionario> FindByCargo(string cargo)
        {
            return GetMemoryDatabase().FindAll(Funcionario => Funcionario.cargo.ToLower().Equals(cargo.ToLower()));
        }

        protected override List<Funcionario> GetMemoryDatabase()
        {
            return _db ?? (_db = new List<Funcionario>());
        }
    }
}
