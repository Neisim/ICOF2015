using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICOF
{
    public class User
    {
        private String user_name;
        private String user_hash;

        public User(String name, String hash)
        {
            user_name = name;
            user_hash = hash;
        }

        public String getName() { return user_name; }
        public String getHash() { return user_hash; }
    }
}
