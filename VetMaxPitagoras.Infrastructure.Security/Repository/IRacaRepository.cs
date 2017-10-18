using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetMaxPitagoras.Core.Repository;
using VetMaxPitagoras.Infrastructure.Security.Entities;

namespace VetMaxPitagoras.Infrastructure.Security.Repository
{
    public interface IRacaRepository : IReposiroty<Raca>
    {
        Raca FindByRaca(string raca);
    }
}
