using Microsoft.AspNet.Mvc;

namespace Daniel15.EFTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
	        return Content("Hello World");
        }
    }
}
