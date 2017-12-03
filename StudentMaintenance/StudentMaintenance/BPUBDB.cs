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
        public static MySqlConnection GetConnection()
        {
            string connectionString =
                "server = localhost; User Id = root; password = swasth00; database = BPUB";
            // is this right?
            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }
    }
}
