using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetMaxPitagoras.Core.Entities;
using VetMaxPitagoras.Core.Repository;

namespace VetMaxPitagoras.Infrastructure.InMemoryRepository
{
    public abstract class Repository<T> : IReposiroty<T> where T:Entity
    {
        protected abstract List<T> GetMemoryDatabase();

        public void Delete(int id)
        {
            var db = GetMemoryDatabase();
            var entityToDelete = db.FirstOrDefault(entity => entity.Id == id);
            GetMemoryDatabase().Remove(entityToDelete);
        }

        public IEnumerable<T> FindAll()
        {
            var db = GetMemoryDatabase();
            return db.ToList();
        }

        public T FindById(int id)
        {
            var db = GetMemoryDatabase();
            return db.FirstOrDefault(entity => entity.Id == id);
        }

        public void Insert(T entityToSave)
        {
            var db = GetMemoryDatabase();
            db.Add(entityToSave);
        }

        public void Update(T entityToSave)
        {
            Delete(entityToSave.Id);
            Insert(entityToSave);
        }
    }
}
