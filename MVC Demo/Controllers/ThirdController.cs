using Microsoft.AspNetCore.Mvc;

namespace MVC_Demo.Controllers
{
    public class ThirdController : Controller
    {
        public IActionResult Index()
        {
            if (1 == 1)
                return View();
            else
            return Content("2222");
        }

        public ContentResult Index1()
        {
            return Content("abc");
        }
        public ViewResult Index2()
        {
            string name = "Deepak Kumar";
            ViewBag.name = name;
            ViewData["date"] = DateTime.Now.ToShortDateString();

            List<string> list = new List<string>() { "deepak", "praveen", "chmadan" };
            ViewBag.names = list;
            ViewData["names"] = list;
            TempData["Manager"] = "JAY KUMAR MEHTA";
            return View();
        }

        public IActionResult A1()
        {
            TempData["Manager"] = "JAY KUMAR MEHTA";
            TempData.Keep("Manager");
            return View();
            //return RedirectToAction("Index");
        }

        public IActionResult A2()
        {
            TempData.Keep("Manager");
            return View();

        }

        public IActionResult A3()
        {
            return View();

        }


    }
}


 // requests are handled in MVC by controller
  // controller is itself a class which inherits from Controller class
  // controller contains public action methods
  // whatever action methods retruns that becomes your output
  //   IACtionResult is an interface
  // ActionResult is an abstract class
// COntentResult , JSONResuylt, ViewResult can return only specific repsonse
// IActionResult / ActionResult can return multiple types of responses based on condition
// 





