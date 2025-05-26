using Microsoft.AspNetCore.Mvc;

namespace MVC_Demo.Controllers
{
    public class SecondController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
