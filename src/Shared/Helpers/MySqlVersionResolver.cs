using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySqlConnector;

namespace ejercicio_5.src.Shared.Helpers
{
    public class MySqlVersionResolver
    {
        public static Version DetectVersion(string connectionString)
        {
            var connection = new MySqlConnection(connectionString);
            connection.Open();
            var raw = connection.ServerVersion;
            var Clean = raw.Split("-")[0];
            return Version.Parse(Clean);
        }
    }
}
