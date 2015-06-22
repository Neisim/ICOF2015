using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ICOF
{
    public class DataBase
    {
        private static String connectionStr = "Server=localhost;Database=icof;Uid=root;Pwd=;";
        private MySqlConnection connection;

        public DataBase()
        {
         
        }

        public String getUserProfile(User u)
        {
            String profile = "Guest";
            String sqlQuery = "SELECT user_profile FROM users WHERE user_name = '" + u.getName() + "' AND user_hash = '" + u.getHash() + "';";
            MySqlCommand sqlCommand = null;
            MySqlDataReader sqlReader = null;
            try
            {
                connection = new MySqlConnection();
                connection.ConnectionString = connectionStr;
                connection.Open();
                sqlCommand = new MySqlCommand(sqlQuery, connection);
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read() != false)
                {
                    profile = sqlReader.GetString(0);
                }
            }
            catch (Exception e)
            {
               MessageBox.Show("Erreur avec la Base de Donées. Contactez votre administrateur de systèmes");
            }
            finally
            {
                connection.Close();
            }
            return profile;
        }
    }
}
