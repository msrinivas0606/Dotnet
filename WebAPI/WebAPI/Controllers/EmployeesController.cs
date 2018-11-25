using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Web.Http;

namespace WebAPI.Controllers
{
    [BasicAuth]
    public class EmployeesController : ApiController
    {
        TestDBEntities dbcontext = new TestDBEntities();
        
        public IEnumerable<Emp> Get()
        {
            return dbcontext.Emps; ;
        }
    }
}
