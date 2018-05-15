using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using xquestBack.DAO;
using xquestBack.DAO.OsVersionData;
using xquestBack.DAO.ProductsData;
using xquestBack.Models;

namespace xquestBack.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        //private MySqlConnection connection = SingletonDatabase.getInstance();
        // GET api/values
        [HttpGet]
        public IEnumerable<Products> Get()
        {
            //IOsVersion context = new MySqlOsVersion();
            IProductsData context = new MySqlProductsData();

            return context.getProducts();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
