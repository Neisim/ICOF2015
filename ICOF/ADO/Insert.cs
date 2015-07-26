using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICOF.Entities;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ICOF.ADO
{
    public class Insert
    {
        private DataBase dataBase;
        private MySqlConnection connection;

        public Insert() { }

        //WORKS
        public String insertCompany(Company company)
        {
            //INSERT COMPANY
            dataBase = new DataBase();
            connection = new MySqlConnection();
            connection = dataBase.getConnection();

            String queryResult = "OK";
            String sqlQuery = "INSERT INTO company VALUES (0, @company_name, @address, @phone, @email, @fax, @activity, @payed_TA, @current_year, @current_TA, @previous_year, @previous_TA);";
            MySqlCommand SqlCommand = new MySqlCommand(sqlQuery, connection);
            String payed_TA = "Non";
            if (company.getTaxe()) payed_TA = "Oui";
            SqlCommand.Parameters.AddWithValue("@company_name",     company.getName());
            SqlCommand.Parameters.AddWithValue("@address",          company.getAddress());
            SqlCommand.Parameters.AddWithValue("@phone",            company.getPhone());
            SqlCommand.Parameters.AddWithValue("@email",            company.getEmail());
            SqlCommand.Parameters.AddWithValue("@fax",              company.getFAX());
            SqlCommand.Parameters.AddWithValue("@activity",         company.getActivity());
            SqlCommand.Parameters.AddWithValue("@payed_TA",         payed_TA);
            SqlCommand.Parameters.AddWithValue("@current_year",     company.getCurrentYear());
            SqlCommand.Parameters.AddWithValue("@current_TA",       company.getCurrentTA());
            SqlCommand.Parameters.AddWithValue("@previous_year",    company.getPreviousYear());
            SqlCommand.Parameters.AddWithValue("@previous_TA",      company.getPreviousTA());

            try
            {
                if (SqlCommand.ExecuteNonQuery() == 1) queryResult = "OK";
            }

            catch (Exception e)
            {
                //MessageBox.Show("Erreur avec la Base de Donées. Contactez votre administrateur de systèmes " + e.Message);
                queryResult = e.Message;
            }

            finally
            {
                connection.Close();
            }
            return queryResult;
        }

        //NOT WORKS FINE
        public String insertPerson(Person p)
        {
            //INSERT PERSON
            dataBase = new DataBase();
            connection = new MySqlConnection();
            connection = dataBase.getConnection();

            String queryResult = "OK";
            String sqlQuery = "INSERT INTO person VALUES (0, @mrmm, @firstname, @lastname, @phone, @email, @icof_p, @company_name, @company_post, @birthdate, @course_done, @year_in, @year_out, @diploma);";
            MySqlCommand SqlCommand = new MySqlCommand(sqlQuery, connection);

            SqlCommand.Parameters.AddWithValue("@mrmm",         p.getMmeMr());
            SqlCommand.Parameters.AddWithValue("@firstname",    p.getFirstName());
            SqlCommand.Parameters.AddWithValue("@lastname",     p.getLastName());
            SqlCommand.Parameters.AddWithValue("@phone",        p.getPhone());
            SqlCommand.Parameters.AddWithValue("@email",        p.getEmail());
            SqlCommand.Parameters.AddWithValue("@icof_p",       p.getIcofPost());
            SqlCommand.Parameters.AddWithValue("@company_name", p.getCompanyName());
            SqlCommand.Parameters.AddWithValue("@company_post", p.getCompanyPost());
            SqlCommand.Parameters.AddWithValue("@birthdate",    p.getBirthDate());
            SqlCommand.Parameters.AddWithValue("@course_done",  p.getCourseDone());
            SqlCommand.Parameters.AddWithValue("@year_in",      p.getYearIn());
            SqlCommand.Parameters.AddWithValue("@year_out",     p.getYearOut());
            SqlCommand.Parameters.AddWithValue("@diploma",      p.getDiploma());
            try
            {
                if (SqlCommand.ExecuteNonQuery() == 1) queryResult = "OK"; 
            }

            catch (Exception e)
            {
                //MessageBox.Show("Erreur avec la Base de Donées. Contactez votre administrateur de systèmes " + e.Message);
                queryResult = e.Message;
            }

            finally
            {
                connection.Close();
            }
            return queryResult;
        }

        //WORKS
        public String insertPostIt(PostIt postIt)
        {
            //INSERT POSTIT
            dataBase = new DataBase();
            connection = new MySqlConnection();
            connection = dataBase.getConnection();

            String queryResult = "OK";
            String sqlQuery = "INSERT INTO post_it VALUES (0, @to_name, @from_name, @date, @subject, @notes, @phone);";
            MySqlCommand SqlCommand = new MySqlCommand(sqlQuery, connection);

            SqlCommand.Parameters.AddWithValue("@to_name",      postIt.getToName());
            SqlCommand.Parameters.AddWithValue("@from_name",    postIt.getFromName());
            SqlCommand.Parameters.AddWithValue("@date",         postIt.getPostItDate());
            SqlCommand.Parameters.AddWithValue("@subject",      postIt.getSubject());
            SqlCommand.Parameters.AddWithValue("@notes",        postIt.getNotes());
            SqlCommand.Parameters.AddWithValue("@phone", postIt.getPhone());
            
            try
            {
                if (SqlCommand.ExecuteNonQuery() == 1) queryResult = "OK";
            }

            catch (Exception e)
            {
                queryResult = e.Message;
            }

            finally
            {
                connection.Close();
            }
            return queryResult;
        }

        //WORKS
        public String insertContactCompany(ContactCompany contact)
        {
            //INSERT CONTACT COMPANY
            dataBase = new DataBase();
            connection = new MySqlConnection();
            connection = dataBase.getConnection();

            String queryResult = "OK";
            String sqlQuery = "INSERT INTO company_contact VALUES (0, @company_name, @contact_firstname, @contact_lastname, @direct_phone, @email, @post);";
            MySqlCommand SqlCommand = new MySqlCommand(sqlQuery, connection);

            SqlCommand.Parameters.AddWithValue("@company_name",         contact.getCompanyName());
            SqlCommand.Parameters.AddWithValue("@contact_firstname",    contact.getFirstName());
            SqlCommand.Parameters.AddWithValue("@contact_lastname",     contact.getLastName());
            SqlCommand.Parameters.AddWithValue("@direct_phone",         contact.getPhone());
            SqlCommand.Parameters.AddWithValue("@email",                contact.getEmail());
            SqlCommand.Parameters.AddWithValue("@post",                 contact.getPost());
            try
            {
                if (SqlCommand.ExecuteNonQuery() == 1) queryResult = "OK";
            }

            catch (Exception e)
            {
                //MessageBox.Show("Erreur avec la Base de Donées. Contactez votre administrateur de systèmes " + e.Message);
                queryResult = e.Message;
            }

            finally
            {
                connection.Close();
            }
            return queryResult;
        }

        //WORKS
        public String insertTrainingStudent(TrainingStudent student)
        {
            //INSERT TRAINING STUDENT
            dataBase = new DataBase();
            connection = new MySqlConnection();
            connection = dataBase.getConnection();

            String queryResult = "OK";
            String sqlQuery = "INSERT INTO students_training VALUES (0, @firstname, @lastname, @company_name, @job_year, @course_name, @teacher_firstName, @teacher_lastName);";
            MySqlCommand SqlCommand = new MySqlCommand(sqlQuery, connection);

            SqlCommand.Parameters.AddWithValue("@firstname",            student.getFirstName());
            SqlCommand.Parameters.AddWithValue("@lastname",             student.getLastName());
            SqlCommand.Parameters.AddWithValue("@company_name",         student.getCompanyName());
            SqlCommand.Parameters.AddWithValue("@job_year",             student.getJobYear());
            SqlCommand.Parameters.AddWithValue("@course_name",          student.getCourseName());
            SqlCommand.Parameters.AddWithValue("@teacher_firstName",    student.getTeacherFirstName());
            SqlCommand.Parameters.AddWithValue("@@teacher_lastName",    student.getTeacherLastName());
            
            try
            {
                if (SqlCommand.ExecuteNonQuery() == 1) queryResult = "OK";
            }

            catch (Exception e)
            {
                //MessageBox.Show("Erreur avec la Base de Donées. Contactez votre administrateur de systèmes " + e.Message);
                queryResult = e.Message;
            }

            finally
            {
                connection.Close();
            }
            return queryResult;
        }
    }
}
