using Microsoft.AspNetCore.Mvc;
using FirstResponsiveWebAppAdolfson.Models;

namespace FirstResponsiveWebAppAdolfson.Controllers
{
    public class AssignmentController : Controller
    {

        private StudentContext context { get; set; }

        public AssignmentController(StudentContext ctx)
        {
            context = ctx;
        }

        public IActionResult Assignment061(int id)
        {
            var student = context.Students.ToList();
            id = 8;
            ViewBag.AccessLevel = id;
            return View(student);
        }

    }
}
