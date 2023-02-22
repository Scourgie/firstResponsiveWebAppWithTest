using Microsoft.AspNetCore.Mvc;
using FirstResponsiveWebAppAdolfson.Models;

namespace FirstResponsiveWebAppAdolfson.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            ViewBag.Age = "0000";

            return View();
        }

        [HttpPost]
        [Route("/")]
        public IActionResult Index(ResponsiveWebAppModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Age = model.AgeThisYear(model.Name, model.BirthYear);
            }
            else
            {
                ViewBag.Age = "0000";
            }

            return View(model);
        }

        [Route("About")]
        public IActionResult About()
        {
            return Content("Home controller, About action");
        }

    }
}
