using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetMaxPitagoras.Core.Repository;
using VetMaxPitagoras.Infrastructure.Security.Entities;

namespace VetMaxPitagoras.Infrastructure.Security.Repository
{
    
          public interface IFuncionarioRepository : IReposiroty<Funcionario>
    {        
        List<Funcionario> FindByName(string nome);
        List<Funcionario> FindByCargo(string cargo);       
    }
    
}
