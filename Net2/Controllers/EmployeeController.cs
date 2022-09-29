using Microsoft.AspNetCore.Mvc;
using Net2.Models;

namespace Net2.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> emp = new List<Employee>();
            emp.Add(new Employee() { EmployeeName = "Ta Thi Van Anh", Age = 21, EmployeeId = 1 });
            emp.Add(new Employee() { EmployeeName = "Ta Thi Van Anh", Age = 21, EmployeeId = 1 });
            emp.Add(new Employee() { EmployeeName = "Ta Thi Van Anh", Age = 21, EmployeeId = 1 });
            emp.Add(new Employee() { EmployeeName = "Ta Thi Van Anh", Age = 21, EmployeeId = 1 });
            emp.Add(new Employee() { EmployeeName = "Ta Thi Van Anh", Age = 21, EmployeeId = 1 });

            ViewData["emps"] = emp;
            ViewData["emp_count"] = emp.Count;
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            string Message = emp.EmployeeId + " - " + emp.EmployeeName + " - " + emp.Age;
            ViewBag.Message = Message;
            return View();
        }
    }
}
