using Hado.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hado.BL.Facade
{
    public class Facade
    {
        SystemOperations system = new SystemOperations();

        public User Check(string username, string password)
        {
            return system.Login(username, password);
        }
    }
}
