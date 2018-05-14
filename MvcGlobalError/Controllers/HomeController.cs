using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcGlobalError.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ControllerError()
        {
            TestController.Calc(2, 0);
            return View();
        }

    }

    public class TestController
    {
        public static int Calc(int a, int b)
        {
            return a / b;
        }
    }
}
