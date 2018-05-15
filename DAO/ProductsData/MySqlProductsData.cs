using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xquestBack.Models;

namespace xquestBack.DAO.ProductsData
{
    public class MySqlProductsData : IProductsData
    {
        private SingletonDatabase singDatabase = null;

        public MySqlProductsData()
        {
            this.singDatabase = SingletonDatabase.getInstance();

        }

        public IEnumerable<Products> getProducts()
        {
            List<Products> products = new List<Products>();
            using (MySqlConnection conn = singDatabase.GetConnection())
            {
                //conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM PRODUCTS WHERE ACTIVE = TRUE", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new Products()
                        {
                            Id = Convert.ToInt32(reader["ID"]),
                            Description = reader["DESCRIPTION"].ToString(),
                            Active = Convert.ToBoolean(reader["ACTIVE"])

                        });
                    }
                }
            }
            return products;

        }
    }
}
