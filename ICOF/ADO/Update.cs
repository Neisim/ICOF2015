using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using ICOF.Entities;

namespace ICOF.ADO
{
    public class Update
    {
        private DataBase dataBase;
        private MySqlConnection connection;

        public Update() {}

        public String updateHash(User u)
        {
            dataBase = new DataBase();
            connection = new MySqlConnection();
            connection = dataBase.getConnection();

            String queryResult = "OK";
            String sqlQuery = "UPDATE users SET user_hash = @user_hash WHERE user_name = @user_name;";
            MySqlCommand SqlCommand = new MySqlCommand(sqlQuery, connection);
            SqlCommand.Parameters.AddWithValue("@user_hash", u.getHash());
            SqlCommand.Parameters.AddWithValue("@user_name", u.getName());
            try
            {
                connection = dataBase.getConnection();
                SqlCommand.ExecuteNonQuery();
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

        public String updateCompany(Company company)
        {
            dataBase = new DataBase();
            connection = new MySqlConnection();
            connection = dataBase.getConnection();

            String queryResult = "OK";
            String sqlQuery = "UPDATE company SET company_name = @company_name, address = @address, phone = @phone, email = @email, fax = @fax, activity = @activity, payed_TA = @payed_TA, current_year = @current_year, current_TA = @current_TA, previous_year = @previous_year, previous_TA = @previous_TA WHERE company_id = @company_id;";  

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
            SqlCommand.Parameters.AddWithValue("@company_id",       company.getID());
            try
            {
                connection = dataBase.getConnection();
                SqlCommand.ExecuteNonQuery();
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

        public String updatePostIt(PostIt postIt)
        {
            dataBase = new DataBase();
            connection = new MySqlConnection();
            connection = dataBase.getConnection();

            String queryResult = "OK";
            String sqlQuery = "UPDATE post_it SET to_name = @to_name, from_ name = @from_name, post_it_date = @post_it_date, subject = @subject, notes = @notes WHERE post_it_id = @post_it_id;";

            MySqlCommand SqlCommand = new MySqlCommand(sqlQuery, connection);

            SqlCommand.Parameters.AddWithValue("@to_name",          postIt.getToName());
            SqlCommand.Parameters.AddWithValue("@from_name",        postIt.getFromName());
            SqlCommand.Parameters.AddWithValue("@post_it_date",     postIt.getPostItDate());
            SqlCommand.Parameters.AddWithValue("@subject",          postIt.getSubject());
            SqlCommand.Parameters.AddWithValue("@notes",            postIt.getNotes());
            SqlCommand.Parameters.AddWithValue("@post_it_id",       postIt.getID());

            try
            {
                connection = dataBase.getConnection();
                SqlCommand.ExecuteNonQuery();
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

        public String updateStudent(TrainingStudent student)
        {
            dataBase = new DataBase();
            connection = new MySqlConnection();
            connection = dataBase.getConnection();

            String queryResult = "OK";
            String sqlQuery = "UPDATE students_training SET student_firstname = @student_firstname, student_lastname = @student_lastname, job_year = @job_year, course_name = @course_name, teacher_firstname = @teacher_firstname, teacher_lastname = @teacher_lastname WHERE student_id = @student_id;";

            MySqlCommand SqlCommand = new MySqlCommand(sqlQuery, connection);
            SqlCommand.Parameters.AddWithValue("@student_firstname",    student.getFirstName());
            SqlCommand.Parameters.AddWithValue("@student_lastname",     student.getLastName());
            SqlCommand.Parameters.AddWithValue("@job_year",             Convert.ToString(student.getJobYear()));
            SqlCommand.Parameters.AddWithValue("@course_name",          student.getCourseName());
            SqlCommand.Parameters.AddWithValue("@teacher_firstname",    student.getTeacherFirstName());
            SqlCommand.Parameters.AddWithValue("@teacher_lastname",     student.getTeacherLastName());
            SqlCommand.Parameters.AddWithValue("@student_id",           student.getID());

            try
            {
                connection = dataBase.getConnection();
                SqlCommand.ExecuteNonQuery();
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

        public String updateContact(ContactCompany contact)
        {
            dataBase = new DataBase();
            connection = new MySqlConnection();
            connection = dataBase.getConnection();

            String queryResult = "OK";
            String sqlQuery = "UPDATE company_contact SET contact_firstname = @contact_firstname, contact_lastname = @contact_lastname, direct_phone = @direct_phone, email = @email, post = @post WHERE contact_id = @contact_id;";

            MySqlCommand SqlCommand = new MySqlCommand(sqlQuery, connection);
            SqlCommand.Parameters.AddWithValue("@contact_firstname",    contact.getFirstName());
            SqlCommand.Parameters.AddWithValue("@contact_lastname",     contact.getLastName());
            SqlCommand.Parameters.AddWithValue("@direct_phone",         contact.getPhone());
            SqlCommand.Parameters.AddWithValue("@email",                contact.getEmail());
            SqlCommand.Parameters.AddWithValue("@post",                 contact.getPost());
            SqlCommand.Parameters.AddWithValue("@contact_id",           contact.getID());

            try
            {
                connection = dataBase.getConnection();
                SqlCommand.ExecuteNonQuery();
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

        public String updatePerson(Person person)
        {
            dataBase = new DataBase();
            connection = new MySqlConnection();
            connection = dataBase.getConnection();

            String queryResult = "OK";
            String sqlQuery = "UPDATE person SET mrmm = @mrmm, person_firstname = @person_firstname, person_lastname = @person_lastname, phone = @phone, email = @email, icof_post = @icof_post, company_name = @company_name, company_post = @company_post, birth_date = @birth_date, course_done = @course_done, year_in = @year_in, year_out = @year_out, diploma = @diploma WHERE person_id = @person_id;";

            MySqlCommand SqlCommand = new MySqlCommand(sqlQuery, connection);
            SqlCommand.Parameters.AddWithValue("@mrmm",             person.getMmeMr());
            SqlCommand.Parameters.AddWithValue("@person_firstname", person.getFirstName());
            SqlCommand.Parameters.AddWithValue("@person_lastname",  person.getLastName());
            SqlCommand.Parameters.AddWithValue("@phone",            person.getPhone());
            SqlCommand.Parameters.AddWithValue("@email",            person.getEmail());
            SqlCommand.Parameters.AddWithValue("@icof_post",        person.getIcofPost());
            SqlCommand.Parameters.AddWithValue("@company_name",     person.getCompanyName());
            SqlCommand.Parameters.AddWithValue("@company_post",     person.getCompanyPost());
            SqlCommand.Parameters.AddWithValue("@birth_date",       person.getBirthDate());
            SqlCommand.Parameters.AddWithValue("@course_done",      person.getCourseDone());
            SqlCommand.Parameters.AddWithValue("@year_in",          person.getYearIn());
            SqlCommand.Parameters.AddWithValue("@year_out",         person.getYearOut());
            SqlCommand.Parameters.AddWithValue("@diploma",          person.getDiploma());
            SqlCommand.Parameters.AddWithValue("@person_id",        person.getID());

            try
            {
                connection = dataBase.getConnection();
                SqlCommand.ExecuteNonQuery();
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
    }
}
