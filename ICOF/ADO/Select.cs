using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Collections;
using ICOF.Entities;

namespace ICOF.ADO
{
    public class Select
    {
        private DataBase dataBase;
        private MySqlConnection connection;

        public Select() { }

        public String selectUserProfile(User user)
        {
            //SELECT USER PROFILE
            dataBase = new DataBase();
            connection = new MySqlConnection();
            connection = dataBase.getConnection();

            String queryResult = "wrong_user";
            String sqlQuery = "SELECT user_profile FROM users WHERE user_name = @user_name AND user_hash = @user_hash;";
            MySqlCommand SqlCommand = null;
            MySqlDataReader sqlReader = null;
            try
            {
                connection = dataBase.getConnection();
                SqlCommand = new MySqlCommand(sqlQuery, connection);
                SqlCommand.Parameters.AddWithValue("@user_name", user.getName());
                SqlCommand.Parameters.AddWithValue("@user_hash", user.getName());
       
                sqlReader = SqlCommand.ExecuteReader();
                while (sqlReader.Read() != false)
                {
                    queryResult = sqlReader.GetString(0);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur avec la Base de Donées. Contactez votre administrateur de systèmes " + e.Message);
            }
            finally
            {
                connection.Close();
            }
            return queryResult;
        }

        public DataTable selectCompanies()
        {
            //SELECT COMPANIES
            dataBase = new DataBase();
            connection = new MySqlConnection();
            connection = dataBase.getConnection();

            MySqlCommand sqlCommand = null;
            MySqlDataAdapter adapter = null;
            DataTable companies = new DataTable();
            //String sqlQuery = "SELECT company_name, address, phone, email, fax, activity, payed_TA, current_year, current_TA, previous_year, previous_TA FROM company;";
            String sqlQuery = "SELECT * FROM company;";
            sqlCommand = new MySqlCommand(sqlQuery, connection);
            adapter = new MySqlDataAdapter(sqlCommand);
            adapter.Fill(companies);
            connection.Close();

            return companies;
        }

        public DataTable selectPersons()
        {
            //SELECT PERSONS
            dataBase = new DataBase();
            connection = new MySqlConnection();
            connection = dataBase.getConnection();

            MySqlCommand sqlCommand = null;
            MySqlDataAdapter adapter = null;
            DataTable persons = new DataTable();
            //String sqlQuery = "SELECT mrmm, person_firstname, person_lastname, phone, email, icof_post, company_name, company_post, birth_date, course_done, year_in, year_out, diploma FROM person;";
            String sqlQuery = "SELECT * FROM person;";
            sqlCommand = new MySqlCommand(sqlQuery, connection);
            adapter = new MySqlDataAdapter(sqlCommand);
            adapter.Fill(persons);
            connection.Close();

            return persons;
        }

        public DataTable selectPostIt(Company company)
        {
            //SELECT POSTIT
            dataBase = new DataBase();
            connection = new MySqlConnection();
            connection = dataBase.getConnection();

            MySqlCommand SqlCommand = null;
            MySqlDataAdapter adapter = null;
            DataTable postIt = new DataTable();
            String sqlQuery = "SELECT * FROM post_it WHERE phone = @companyPhone;";
            SqlCommand = new MySqlCommand(sqlQuery, connection);
            SqlCommand.Parameters.AddWithValue("@companyPhone", company.getPhone());

            adapter = new MySqlDataAdapter(SqlCommand);
            adapter.Fill(postIt);
            connection.Close();

            return postIt;
        }

        public DataTable selectContactCompany(Company company)
        { 
            //SELECT CONTACT COMPANY
            dataBase = new DataBase();
            connection = new MySqlConnection();
            connection = dataBase.getConnection();

            MySqlCommand SqlCommand = null;
            MySqlDataAdapter adapter = null;
            DataTable contacts = new DataTable();
            String sqlQuery = "SELECT * FROM company_contact WHERE company_name = @companyName;";
            SqlCommand = new MySqlCommand(sqlQuery, connection);
            SqlCommand.Parameters.AddWithValue("@companyName", company.getName());

            adapter = new MySqlDataAdapter(SqlCommand);
            adapter.Fill(contacts);
            connection.Close();

            return contacts;
        }

        public DataTable selectTrainigStudent(Company company)
        { 
            //SELECT TRAINING STUDENTS
            dataBase = new DataBase();
            connection = new MySqlConnection();
            connection = dataBase.getConnection();

            MySqlCommand SqlCommand = null;
            MySqlDataAdapter adapter = null;
            DataTable students = new DataTable();
            String sqlQuery = "SELECT * FROM students_training WHERE company_name = @companyName;";
            SqlCommand = new MySqlCommand(sqlQuery, connection);
            SqlCommand.Parameters.AddWithValue("@companyName", company.getName());
            
            adapter = new MySqlDataAdapter(SqlCommand);
            adapter.Fill(students);
            connection.Close();

            return students;
        }

        public ArrayList selectCourses()
        {
            //SELECT COURSES
            dataBase = new DataBase();
            connection = new MySqlConnection();
            connection = dataBase.getConnection();

            ArrayList courses = new ArrayList();
            MySqlCommand sqlCommand = null;
            MySqlDataReader reader = null; 
            String sqlQuery = "SELECT course_name FROM courses";
            sqlCommand = new MySqlCommand(sqlQuery, connection);
            reader = sqlCommand.ExecuteReader();
            while (reader.Read() != false)
            {
                courses.Add(reader.GetString(0));
            }
            connection.Close();
            return courses;
        }

        public ArrayList selectICOFPost()
        {
            //SELECT COURSES
            dataBase = new DataBase();
            connection = new MySqlConnection();
            connection = dataBase.getConnection();

            ArrayList post = new ArrayList();
            MySqlCommand sqlCommand = null;
            MySqlDataReader reader = null;
            String sqlQuery = "SELECT post_name FROM icof_post";
            sqlCommand = new MySqlCommand(sqlQuery, connection);
            reader = sqlCommand.ExecuteReader();
            while (reader.Read() != false) post.Add(reader.GetString(0));
            connection.Close();
            return post;
        }

        //Changes the user hash
        /*public String changerUserHash(User u)
        {
            String queryResult = "change_error";
            String sqlQuery = "UPDATE users SET user_hash = '" + u.getHash() + "' WHERE user_name = '" + u.getName() + "';";
            MySqlCommand sqlCommand = null;
            try
            {
                _connection = new MySqlConnection();
                _connection.ConnectionString = connectionStr;
                _connection.Open();
                sqlCommand = new MySqlCommand(sqlQuery, _connection);
                if (sqlCommand.ExecuteNonQuery() == 1) queryResult = "OK";
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur avec la Base de Donées. Contactez votre administrateur de systèmes");
            }
            finally
            {
                _connection.Close();
            }
            return queryResult;
        }*/
    }
}
