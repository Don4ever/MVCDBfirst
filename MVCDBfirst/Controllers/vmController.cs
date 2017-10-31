using MVCDBfirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDBfirst.Controllers
{
    public class vmController : Controller
    {
        
        // GET: test
        public ActionResult Index()
        {

            user emp = new user();
            emp.user_id = 20000;
            emp.password = "Marla";
            emp.user_name = "Sukesh";

            ViewData["Employee"] = emp;
            return View("vm");
        }
        // GET: test
        
    }
}