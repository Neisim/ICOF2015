using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICOF.Entities
{
    public class Person
    {
        private int         _ID;
        private String      _mmemr;
        private String      _firstName;
        private String      _lastName;
        private String      _phone;
        private String      _email;
        private String      _icofPost;
        private String      _companyName;
        private String      _companyPost;
        private String      _birthDate;
        private String      _courseDone;
        private String      _yearIn;
        private String      _yearOut;
        private String      _diploma;

        public Person() { }

        public Person(int ID, String mmemr, String firstName, String lastName, String phone, String email, String icofPost, String companyName, String companyPost, String birthDate, String courseDone, String yearIn, String yearOut, String diploma)
        {
            _ID = ID;
            _mmemr = mmemr;
            _firstName = firstName;
            _lastName = lastName;
            _phone = phone;
            _email = email;
            _icofPost = icofPost;
            _companyName = companyName;
            _companyPost = companyPost;
            _birthDate = birthDate;
            _courseDone = courseDone;
            _yearIn = yearIn;
            _yearOut = yearOut;
            _diploma = diploma;
        }

        //GETTERS
        public int getID()              { return _ID; }
        public String getMmeMr()        { return _mmemr; }
        public String getFirstName()    { return _firstName; }
        public String getLastName()     { return _lastName; }
        public String getPhone()        { return _phone; }
        public String getEmail()        { return _email; }
        public String getIcofPost()     { return _icofPost; }
        public String getCompanyName()  { return _companyName; }
        public String getCompanyPost()  { return _companyPost; }
        public String getBirthDate()    { return _birthDate; }
        public String getCourseDone()   { return _courseDone; }
        public String getYearIn()       { return _yearIn; }
        public String getYearOut()      { return _yearOut; }
        public String getDiploma()      { return _diploma; }


        //SETTERS
        public void setID(int ID)                           { _ID = ID; }
        public void setMmeMR(String mmemr)                  { _mmemr = mmemr; }
        public void setFirstName(String firstName)          { _firstName = firstName; }
        public void setLastName(String lastName)            { _lastName = lastName; }
        public void setPhone(String phone)                  { _phone = phone; }
        public void setEmail(String email)                  { _email = email; }
        public void setIcofPost(String icofPost)            { _icofPost = icofPost; }
        public void setCompanyName(String companyName)      { _companyName = companyName; }
        public void setCompanyPost(String companyPost)      { _companyPost = companyPost; }
        public void setBirthDate(String birthDate)          { _birthDate = birthDate; }
        public void setCourseDone(String courseDone)        { _courseDone = courseDone; }
        public void setYearIn(String yearIn)                { _yearIn = yearIn; }
        public void setYearOut(String yearOut)              { _yearOut = yearOut; }
        public void setDiploma(String diploma)              { _diploma = diploma; }
    }
}
