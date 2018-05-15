using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xquestBack.Models;

namespace xquestBack.DAO
{
    //interface criada com o intuito de ser expansivel caso se torne necesário usar outro banco ou tecnologia
    interface IOsVersion
    {
        IEnumerable<OsVersion> GetOsVersion();
     

    }
}
