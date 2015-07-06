using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICOF
{
    public class User
    {
        private String _userName;
        private String _userHash;

        public User(String name, String hash)
        {
            _userName = name;
            _userHash = hash;
        }

        //GETTERS
        public String getName() { return _userName; }
        public String getHash() { return _userHash; }

        //SETTERS
        public void setName(String name) { _userName = name; }
        public void setHash(String hash) { _userHash = hash; }
    }
}
