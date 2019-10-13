using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Incriminatr.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() => RedirectToAction("Lobby", "Chat");
    }
}