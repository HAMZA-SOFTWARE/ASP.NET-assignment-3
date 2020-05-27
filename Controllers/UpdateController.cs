using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace emp_mang_asp.Controllers
{
    public class UpdateController : Controller
    {
        // GET: Update
        public ActionResult UpdateEMP(string empID, string empName, string empSal, string empDept, string empAddress)
        {
            ViewBag.empID = empID;
            ViewBag.empName = empName;
            ViewBag.empsal = empSal;
            ViewBag.empDept = empDept;
            ViewBag.empAddress = empAddress;
            return View();
        }

        public ActionResult UpdateEmployee(string empID, string empName, string empSal, string empDept, string empAddress)
        {
            EmployeeModelContainer mc = new EmployeeModelContainer();
            Employee obj = new Employee();
            obj.Id = Convert.ToInt32(empID);
            obj.EmpName = empName;
            obj.EmpSalary = empSal;
            obj.EmpDept = empDept;
            obj.EmpAddress = empAddress;

            mc.Employees.AddOrUpdate(obj);
            mc.SaveChanges();
            return Redirect("/printall");
        }
    }
}