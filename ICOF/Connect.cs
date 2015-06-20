using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace ICOF
{
    public class Connect
    {
        public static String connectionStr = "Server=localhost;Database=icof;Uid=root;Pwd=;";

        public Connect()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = connectionStr;
                connection.Open();
                MessageBox.Show("Connection done!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e.Message);
            }
        }
    }
}
