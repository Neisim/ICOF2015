using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICOF.Entities
{
    public class PostIt
    {
        private int     _ID;
        private String  _toName;
        private String  _fromName;
        private String  _postItDate;
        private String  _subject;
        private String  _notes;
        private String  _phone;

        public PostIt() { }

        public PostIt(int ID, String toName, String fromName, String postItDate, String subject, String notes, String phone)
        {
            _ID = ID;
            _toName = toName;
            _fromName = fromName;
            _postItDate = postItDate;
            _subject = subject;
            _notes = notes;
            _phone = phone;
        }

        //GETTERS
        public int getID()              { return _ID; }
        public String getToName()       { return _toName; }
        public String getFromName()     { return _fromName; }
        public String getPostItDate()   { return _postItDate; }
        public String getSubject()      { return _subject; }
        public String getNotes()        { return _notes; }
        public String getPhone()        { return _phone; }

        //SETTERS
        public void setID(int ID)                       { _ID = ID; }
        public void setToName(String toName)            { _toName = toName; }
        public void setFromName(String fromName)        { _fromName = fromName; }
        public void setPostItDate(String postItDate)    { _postItDate = postItDate; }
        public void setSubject(String subject)          { _subject = subject; }
        public void setNotes(String notes)              { _notes = notes; }
        public void setPhone(String phone)              { _phone = phone; }
    }
}
