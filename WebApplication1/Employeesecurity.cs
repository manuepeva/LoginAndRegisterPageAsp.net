using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Employeesecurity
    {
        public static bool Login(string username, string password)
        {
            using(MyConnectionDB entities = new MyConnectionDB())
            {
                return entities.Users.Any(username => user.username.equals(username,
                    StringComparison.OrdinalIgnoreCase) && user.Password == password);
                    ))
            }
        }
    }
}