using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace emp_mang_asp.Controllers
{
    public class CreateController : Controller
    {
        // GET: Create
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateEMP(string empName, string empSal, string empDept, string empAddress)
        {
            Employee emp = new Employee();
            emp.EmpName = empName;
            emp.EmpSalary = empSal;
            emp.EmpDept = empDept;
            emp.EmpAddress = empAddress;
            EmployeeModelContainer mc = new EmployeeModelContainer();
            mc.Employees.Add(emp);
            mc.SaveChanges();

            return Redirect("/printall");
        }

    }
}