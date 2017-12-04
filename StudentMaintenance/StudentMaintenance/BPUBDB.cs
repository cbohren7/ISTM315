using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StudentMaintenance
{
    public static class BPUBDB
    {
        /// <summary>
        /// This is the information for the connection to the MySql database.
        /// </summary>
        /// <returns>connection</returns>
        public static MySqlConnection GetConnection()
        {
            string connectionString =
                "server = localhost; User Id = root; password = password; database = BPUB";
            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }
    }
}
