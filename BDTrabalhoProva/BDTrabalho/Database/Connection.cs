using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDTrabalho.Database
{
    class Connection
    {
        public MySqlConnection Create()
        {
            string connectionString = "server=localhost;database=DB_multas;uid=root;password=1234";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            return connection;
        }
    }
}
