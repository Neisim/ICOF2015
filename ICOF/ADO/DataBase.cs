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
        //private static String connectionStr = "Server=mysql55-4.pro;Database=icofcampanc;Uid=icofcampanc;Pwd=Nassim69;";
        private MySqlConnection connection;

        public DataBase()
        {
            try
            {
                connection = new MySqlConnection();
                connection.ConnectionString = connectionStr;
                connection.Open();
            }
            catch (MySqlException e) {
                MessageBox.Show("Erreur avec la base de donées. Contactez avec l'administrateur de systemes.", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public MySqlConnection getConnection() { return connection; }
    }
}
