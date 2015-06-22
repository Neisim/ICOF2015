using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICOF
{
    class Controller
    {

        public Controller() { }

        public String userProfile(User u) {
            DataBase connect = new DataBase();
            return connect.getUserProfile(u);
        }
    }
}
