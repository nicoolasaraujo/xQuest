using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xquestBack.DAO
{
    public class SingletonDatabase
    {

        public static SingletonDatabase instanceDb = null;
        public readonly MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Database=xquest;Uid=root;Pwd=12345;SslMode=none");

        private SingletonDatabase() { }

        public static SingletonDatabase getInstance()
        {
            if (instanceDb == null)
            {
                instanceDb = new SingletonDatabase();

            }
            return instanceDb;
        }

        public MySqlConnection GetConnection()
        {

            try
            {
                conn.Open();

            }
            catch (Exception)
            {
                return null;
            }

            return conn;

        }

    }
}
