﻿using System;
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
                "Provider = MySQL Provider; server = localhost; User Id = root; password = mypassword; database = BPUB";
            // is this right?
            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }
    }
}
