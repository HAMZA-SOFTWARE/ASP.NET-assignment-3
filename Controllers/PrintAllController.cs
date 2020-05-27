using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace emp_mang_asp.Controllers
{
    public class PrintAllController : Controller
    {
        //GET: PrintAll
        public ActionResult Index()
        {
            EmployeeModelContainer mc = new EmployeeModelContainer();
            List<Employee> l1 = new List<Employee>();

            foreach (var i in mc.Employees)
            {
                l1.Add(i);
            }

            return View(l1);
        }
    }
}