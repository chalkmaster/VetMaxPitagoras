using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetMaxPitagoras.Infrastructure.Security.Entities;
using VetMaxPitagoras.Infrastructure.Security.Repository;

namespace VetMaxPitagoras.Infrastructure.Security.Services
{
    public class RacaService
    {
        private IRacaRepository _repositorio;

        public RacaService(IRacaRepository racaRepository)
        {
            _repositorio = racaRepository;
        }

        public List<Raca> GetRacas()
        {
            return (List<Raca>)_repositorio.FindAll();
        }
    }
}
