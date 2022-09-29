using Microsoft.AspNetCore.Mvc;
using Net2.Models;

namespace Net2.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            List<Person> ps = new List<Person>();
            ps.Add(new Person() { PersonName = "Ta Thi Van Anh", Age = 21, PersonId = 1 });
            ps.Add(new Person() { PersonName = "Ta Thi Van Anh", Age = 21, PersonId = 1 });
            ps.Add(new Person() { PersonName = "Ta Thi Van Anh", Age = 21, PersonId = 1 });
            ps.Add(new Person() { PersonName = "Ta Thi Van Anh", Age = 21, PersonId = 1 });
            ps.Add(new Person() { PersonName = "Ta Thi Van Anh", Age = 21, PersonId = 1 });

            ViewData["persons"] = ps;
            ViewData["person_count"] = ps.Count;
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Person ps)
        {
            string Message = ps.PersonId + " - " + ps.PersonName + " - " + ps.Age;
            ViewBag.Message = Message;
            return View();
        }
    }
}
