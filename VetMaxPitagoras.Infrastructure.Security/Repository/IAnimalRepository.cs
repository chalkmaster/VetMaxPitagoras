using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetMaxPitagoras.Core.Repository;
using VetMaxPitagoras.Infrastructure.Security.Entities;

namespace VetMaxPitagoras.Infrastructure.Security.Repository
{
<<<<<<< HEAD

    public interface IAnimalRepository : IReposiroty<Animal>
    {
        Animal FindByUserName(string username);

=======
    public interface IAnimalRepository : IReposiroty<Animal>
    {        
        List<Animal> FindByName(string nome);
        List<Animal> FindByProprietarioName(string nome);
>>>>>>> original
    }
}
