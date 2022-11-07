using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WebApplicationmy.DAL;
using WebApplicationmy.Models;

namespace WebApplicationmy.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> oEmployee = new List<Employee>();

            return View(oEmployee);
        }
        [HttpPost]
        public JsonResult save(Employee oEmployee)
        {
            EmployeeDAL obj = new EmployeeDAL();
          int i=obj.save(oEmployee);
             //JavaScriptSerializer serializer = new JavaScriptSerializer();
            //string json = serializer.Serialize(oEmployee);
            return Json(i, JsonRequestBehavior.AllowGet);
        }
    }
}