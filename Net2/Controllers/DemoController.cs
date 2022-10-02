using Microsoft.AspNetCore.Mvc;
using Net2.Models;

namespace Net2.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string str)
        {
            StringProcess sp = new StringProcess();
            ViewBag.thongTin = sp.RemoveVietnamese(str);
            return View();
        }
    }


}
