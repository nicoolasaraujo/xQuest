using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xquestBack.Models;
using MySql.Data.MySqlClient;

namespace xquestBack.DAO.OsVersionData
{
    public class MySqlOsVersion : IOsVersion
    {

        private SingletonDatabase singDatabase = null;

        public MySqlOsVersion()
        {
            this.singDatabase = SingletonDatabase.getInstance();

        }
        

        public IEnumerable<OsVersion> GetOsVersion()
        {
            List<OsVersion> list = new List<OsVersion>();

            using (MySqlConnection conn = singDatabase.GetConnection())
            {
                //conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM OSVERSIONS", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new OsVersion()
                        {
                            id = Convert.ToInt32(reader["ID"]),
                            Description = reader["DESCRIPTION"].ToString()
                            
                        });
                    }
                }
            }
            return list;


            
        }
    }
}
