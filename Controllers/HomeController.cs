using Microsoft.AspNet.Mvc;
using System;

namespace Daniel15.EFTest.Controllers
{
    public class HomeController : Controller
    {
	    private readonly MyContext _context;

	    public HomeController(MyContext context)
	    {
		    _context = context;
	    }

        public IActionResult Index()
        {
	        return View(_context.Posts);
        }

	    public IActionResult Create()
	    {
		    _context.Posts.Add(new Post {Title = "New From Code at " + DateTime.Now, Content = "Woot"});
		    _context.SaveChanges();
		    return Content("Done");
	    }
    }
}
