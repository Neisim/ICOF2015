using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICOF.Entities
{
    public class Company
    {
        private String  _name;
        private String  _address;
        private String  _phone;
        private String  _email;
        private String  _FAX;
        private String  _activity;
        private Boolean _taxe;
        private int     _currentYear;
        private Double  _currentTA;
        private int     _previousYear;
        private Double  _previousTA;

        public Company() { }

        public Company(String name, String address, String phone, String email, String FAX, String activity, Boolean taxe, int currentYear, Double currentTA, int previousYear, Double previousTA) {
            _name = name;
            _address = address;
            _phone = phone;
            _email = email;
            _FAX = FAX;
            _activity = activity;
            _taxe = taxe;
            _currentYear = currentYear;
            _currentTA = currentTA;
            _previousYear = previousYear;
            _previousTA = previousTA;
        }

        //GETTERS
        public String getName()         { return _name; }
        public String getAddress()      { return _address; }
        public String getPhone()        { return _phone; }
        public String getEmail()        { return _email; }
        public String getFAX()          { return _FAX; }
        public String getActivity()     { return _activity; }
        public Boolean  getTaxe()           { return _taxe; }
        public int      getCurrentYear()    { return _currentYear; }
        public Double   getCurrentTA()      { return _currentTA; }
        public int      getPreviousYear()   { return _previousYear; }
        public Double   getPreviousTA()     { return _previousTA; }

        //SETTERS
        public void setName(String name)                { _name = name; }
        public void setAddress(String address)          { _address = address; }
        public void setPhone(String phone)              { _phone = phone; }
        public void setEmail(String email)              { _email = email; }
        public void setFAX(String FAX)                  { _FAX = FAX; }
        public void setActivity(String activity)        { _activity = activity; }
        public void setTaxe(Boolean taxe)               { _taxe = taxe; }
        public void setCurrentYear(int currentYear)     { _currentYear = currentYear; }
        public void setCurrentTA(Double currentTA)      { _currentTA = currentTA; }
        public void setPreviousYear(int previousYear)   { _previousYear = previousYear; }
        public void setPreviousTA(Double previousTA)    { _currentTA = previousTA; }
    }
}
