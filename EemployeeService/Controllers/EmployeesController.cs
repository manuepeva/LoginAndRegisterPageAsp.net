using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EemployeeService.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<EMPLOYEESTABLE> Get()
        {
            using(MisEntidadesModelo entities = new MisEntidadesModelo())
            {
                return entities.EMPLOYEESTABLE.ToList();
            }
        }
    }
}
