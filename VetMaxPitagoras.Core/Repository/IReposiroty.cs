using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetMaxPitagoras.Core.Entities;

namespace VetMaxPitagoras.Core.Repository
{
    public interface IReposiroty<T> where T : Entity
    {
        T FindById(int id);
        IEnumerable<T> FindAll();
        void Insert(T entityToSave);
        void Update(T entityToSave);
        void Delete(int id);
    }
}
