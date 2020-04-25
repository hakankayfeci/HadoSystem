using Hado.BL.UnitOfWork.Concrede;
using Hado.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hado.BL.Facade
{
    public class SystemOperations
    {
        UserRepository userRepository = new UserRepository();
        public User UserGet(string username,string password)
        {
            return userRepository.GetByFilter(x => x.Username == username && x.Password==password).FirstOrDefault();
        }

        public User Login(string username, string password)
        {
            return UserGet(username, password);
        }
    }
}
