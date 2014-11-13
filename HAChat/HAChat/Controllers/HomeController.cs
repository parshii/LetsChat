using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;

namespace HAChat.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Chat()
        {
            return View();
        }

        public string GetTempPath()
        {
            string path = System.Environment.GetEnvironmentVariable("TEMP");
            if (!path.EndsWith("\\")) path += "\\";
            return path;
        }
   
    }
}