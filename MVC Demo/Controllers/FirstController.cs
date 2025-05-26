using Microsoft.AspNetCore.Mvc;

namespace MVC_Demo.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            return View();  

        }

        public IActionResult Index1()
        {

        return View(); 
        
        }
    }
         
    }

