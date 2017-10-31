using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetMaxPitagoras.Infrastructure.Security.Entities;
using VetMaxPitagoras.Infrastructure.Security.Repository;

namespace VetMaxPitagoras.Infrastructure.Security.Services
{
    public class EspecieService
    {
        private IEspecieRepository _repositorio;

        public EspecieService(IEspecieRepository especieRepository)
        {
            _repositorio = especieRepository;

        }


        public List<Especie> GetEspecies()
        {
            return (List<Especie>) _repositorio.FindAll();
        }
    }
}
