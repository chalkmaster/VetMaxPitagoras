using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetMaxPitagoras.Infrastructure.Security.Entities;
using VetMaxPitagoras.Infrastructure.Security.Repository;

namespace VetMaxPitagoras.Infrastructure.InMemoryRepository.Security
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private static List<User> _db;

        public User FindByUserName(string username)
        {
            return GetMemoryDatabase().FirstOrDefault(user => user.UserName.ToLower() == username.ToLower());
        }

        protected override List<User> GetMemoryDatabase()
        {
            return _db ?? (_db = new List<User>());
        }
    }
}
