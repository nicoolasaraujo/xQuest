using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xquestBack.Models;

namespace xquestBack.DAO
{
    interface IProductsData
    {

        IEnumerable<Products> getProducts();


    }
}
