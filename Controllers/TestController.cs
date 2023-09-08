using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication_DAY9.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
			ViewBag.Message = "Hello, World! MVC";

			//return Content("Hello, World!");
            return View();

		}
    }
}