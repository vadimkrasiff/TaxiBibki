using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TaxiBibki
{
    internal class MySQL
    {
        public static MySqlConnection getConnection()
        {
            string myConnectionString = "server=localhost;user=root;database=bibki_db;";
            MySqlConnection myConnection = new MySqlConnection(myConnectionString);

            return myConnection;
        }
    }
}
