using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetMaxPitagoras.Infrastructure.Security.Entities;
using VetMaxPitagoras.Infrastructure.Security.Repository;

namespace VetMaxPitagoras.Infrastructure.Security.Services
{
    public class AuthService
    {
        private IUserRepository _userRepository;
        public AuthService(IUserRepository repository)
        {
            _userRepository = repository;
        }

        public bool TryAuthenticate(User userToAuthenticate)
        {
            var userFound = _userRepository.FindByUserName(userToAuthenticate.UserName);
            if(userFound != null)
            {
                return userFound.Password == userToAuthenticate.Password;
            }
            return false;
        }
        public void AddNewUser(User userToInsert)
        {
            _userRepository.Insert(userToInsert);
        }
    }
}
