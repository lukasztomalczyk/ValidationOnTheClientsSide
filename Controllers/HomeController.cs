using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationClientSite.Models;

namespace ValidationClientSite.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Person _person)
        {
            return (ModelState.IsValid) ?  View("Index", _person) : View();
        }
    }
}