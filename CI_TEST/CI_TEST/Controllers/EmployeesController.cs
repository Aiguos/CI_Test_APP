using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using CI_TEST.Models;

namespace CI_TEST.Controllers
{
    public class EmployeesController : ApiController
    {

        private TestDBEntities _db;

        public EmployeesController()
        {
            _db = new TestDBEntities();
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _db.Employees.ToList();
        }
    }
}