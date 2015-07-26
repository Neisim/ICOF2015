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
    public class Delete
    {
        private DataBase _dataBase;
        private MySqlConnection _connection;

        public Delete() {}

        public String deleteCompany(Company company)
        {
            _dataBase = new DataBase();
            _connection = new MySqlConnection();
            _connection = _dataBase.getConnection();

            String queryResult = "OK";
            String sqlQuery = "DELETE FROM company WHERE company_id = @company_id;";  

            MySqlCommand SqlCommand = new MySqlCommand(sqlQuery, _connection);
            SqlCommand.Parameters.AddWithValue("@company_id", company.getID());
            try
            {
                _connection = _dataBase.getConnection();
                SqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                queryResult = e.Message;
            }
            finally
            {
                _connection.Close();
            }
            return queryResult;
        }

        public String deletePostIt(PostIt postIt)
        {
            _dataBase = new DataBase();
            _connection = new MySqlConnection();
            _connection = _dataBase.getConnection();

            String queryResult = "OK";
            String sqlQuery = "DELETE FROM post_it WHERE post_it_id = @post_it_id;";

            MySqlCommand SqlCommand = new MySqlCommand(sqlQuery, _connection);

            SqlCommand.Parameters.AddWithValue("@post_it_id", postIt.getID());
            try
            {
                _connection = _dataBase.getConnection();
                SqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                queryResult = e.Message;
                MessageBox.Show(e.Message);
            }
            finally
            {
                _connection.Close();
            }
            return queryResult;
        }

        public String deleteStudent(TrainingStudent student)
        {
            _dataBase = new DataBase();
            _connection = new MySqlConnection();
            _connection = _dataBase.getConnection();

            String queryResult = "OK";
            String sqlQuery = "DELETE FROM students_training WHERE student_id = @student_id;";

            MySqlCommand SqlCommand = new MySqlCommand(sqlQuery, _connection);
            SqlCommand.Parameters.AddWithValue("@student_id", student.getID());

            try
            {
                _connection = _dataBase.getConnection();
                SqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                queryResult = e.Message;
            }
            finally
            {
                _connection.Close();
            }
            return queryResult;
        }

        public String deleteContact(ContactCompany contact)
        {
            _dataBase = new DataBase();
            _connection = new MySqlConnection();
            _connection = _dataBase.getConnection();

            String queryResult = "OK";
            String sqlQuery = "DELETE FROM company_contact WHERE contact_id = @contact_id;";

            MySqlCommand SqlCommand = new MySqlCommand(sqlQuery, _connection);

            SqlCommand.Parameters.AddWithValue("@contact_id", contact.getID());
            try
            {
                _connection = _dataBase.getConnection();
                SqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                queryResult = e.Message;
                MessageBox.Show(e.Message);
            }
            finally
            {
                _connection.Close();
            }
            return queryResult;
        }

        public String deletePerson(Person person)
        {
            _dataBase = new DataBase();
            _connection = new MySqlConnection();
            _connection = _dataBase.getConnection();

            String queryResult = "OK";
            String sqlQuery = "DELETE FROM person WHERE person_id = @person_id;";

            MySqlCommand SqlCommand = new MySqlCommand(sqlQuery, _connection);

            SqlCommand.Parameters.AddWithValue("@person_id", person.getID());
            try
            {
                _connection = _dataBase.getConnection();
                SqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                queryResult = e.Message;
                MessageBox.Show(e.Message);
            }
            finally
            {
                _connection.Close();
            }
            return queryResult;
        }
    }
}
