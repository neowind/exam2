using System;
using System.Web;
using System.Web.Mvc;
using System.Web;

namespace Agoda.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}