using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICOF.Entities;
using ICOF.ADO;
using System.Data;

namespace ICOF
{
    public class Controller
    {
        private Insert insert;
        private Select select;
        private Update update;

        public Controller() {
            insert = new Insert();
            select = new Select();
            update = new Update();
        }
        
        //INSERT
        public String insertCompany(Company c)                                  { return insert.insertCompany(c); }
        public String insertPerson(Person p)                                    { return insert.insertPerson(p); }
        public String insertPostIt(PostIt postIt)                               { return insert.insertPostIt(postIt); }
        public String insertContactCompany(ContactCompany contact)              { return insert.insertContactCompany(contact); }
        public String insertTrainingStudent(TrainingStudent training_student)   { return insert.insertTrainingStudent(training_student); }
        
        //SELECT
        public String userProfile(User u)                           { return select.selectUserProfile(u); }
        public DataTable getContacts(Company company)               { return select.selectContactCompany(company); }
        public DataTable getTrainingStudents(Company company)       { return select.selectTrainigStudent(company); }
        public DataTable getPostIt(Company company)                 { return select.selectPostIt(company); }
        public DataTable getCompanies()                             { return select.selectCompanies(); }
        public DataTable getPersons()                               { return select.selectPersons(); } 
        public ArrayList getCourses()                               { return select.selectCourses(); }
        public ArrayList getPosts()                                 { return select.selectICOFPost(); }

        //UPDATE
        public String userHash(User u) { return update.updateHash(u); }
    }
}
