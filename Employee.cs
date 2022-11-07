using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationmy.DAL;

namespace WebApplicationmy.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int ContactNo { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        //public void save(Employee oEmployee)
        //{
        //    EmployeeDAL oEmployeeDAL = new EmployeeDAL();

        //    oEmployeeDAL.save(oEmployee);

        //}
    }
}