using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLChoThueXe;

namespace BUS_QLChoThueXe
{
    public class BUS_Login
    {
        DAL_Login dAL_Login = new DAL_Login();
        public bool getUser(string username, string password)
        {
            return dAL_Login.getUser(username, password);
        }
    }
}
