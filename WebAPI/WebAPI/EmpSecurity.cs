using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI
{
    public class EmpSecurity
    {

        public static bool Login(string username, string password)
        {
            using (TestDBEntities dbcontext = new TestDBEntities())
            {
               // if (dbcontext.Users.Any(x => x.UserName.Equals(username) && x.Password.Equals(password)))
                    return true;
                //else
                //    return false;
            }
        }
    }
}