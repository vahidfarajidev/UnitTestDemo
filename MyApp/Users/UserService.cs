using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Users
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public string GetWelcomeMessage(int id)
        {
            var name = _userRepository.GetUserName(id);
            return $"Welcome, {name}";
        }
    }
}
