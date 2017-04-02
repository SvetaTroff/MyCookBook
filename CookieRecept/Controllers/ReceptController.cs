using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CookieRecept.Controllers
{
    public class ReceptController : Controller
    {
        // GET: Recept
        public ActionResult Index()
        {
            return View();
        }
    }
}