using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FT_GO___OFICIAL.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index_semLogin()
        {
            return View();
        }
    }
}