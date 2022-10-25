using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment1.Controllers
{
    public class CVController : Controller
    {
        // GET: CV
        public ActionResult cv()
        {
           return View();   
        }
    }
}