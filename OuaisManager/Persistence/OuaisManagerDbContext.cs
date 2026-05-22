using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OuaisManager.Persistence
{
    public class OuaisManagerDbContext
    {
        private string _dbConnectionString;

        public OuaisManagerDbContext()
        {
            _dbConnectionString = File.ReadAllText();
        }

        public MySqlConnection ConnectDatabase()
        {
            var conn = new MySqlConnection(_dbConnectionString);  // Initialiser la connexion une seule fois
            try
            {
                conn.Open();
                return conn;
            }
            catch (MySqlException ex)
            {
                return null;
            }
        }
    }
}
