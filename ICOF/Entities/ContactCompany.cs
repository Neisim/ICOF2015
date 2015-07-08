using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICOF.Entities
{
    public class ContactCompany
    {
        private String  _companyName;
        private String  _contactFirstName;
        private String  _contactLastName;
        private String  _phone;      
        private String  _email;
        private String  _post;

        public ContactCompany() { }

        public ContactCompany(String companyName, String contactFirstName, String contactLastName, String phone, String email, String post) {
            _companyName = companyName;
            _contactFirstName = contactFirstName;
            _contactLastName = contactLastName;
            _phone = phone;
            _email = email;
            _post= post;
        }

        //GETTERS
        public String getCompanyName()          { return _companyName; }
        public String getcontactFirstName()     { return _contactFirstName; }
        public String getcontactLastName()      { return _contactLastName; }
        public String getPhone()                { return _phone; }
        public String getEmail()                { return _email; }
        public String getPost()                 { return _post; }

        //SETTERS
        public void setCompanyName(String companyName)              { _companyName = companyName; }
        public void setcontactFirstName(String contactFirstName)    { _contactFirstName = contactFirstName; }
        public void setcontactLastName(String contactLastName)      { _contactLastName = contactLastName; }
        public void setPhone(String phone)                          { _phone = phone; }
        public void setEmail(String email)                          { _email = email; }
        public void setPost(String post)                            { _post = post; }
    }
}
