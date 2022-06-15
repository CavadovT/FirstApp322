using Microsoft.AspNetCore.Mvc;

namespace FirstApp322.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult GetInfo(int id)
        {
            return Json(new
            {
                Id=$"Id={id}",
                name = "Tural",
                surname = "Javadov",
                Age = 28

            });


        }
        public IActionResult Index(int id)
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
