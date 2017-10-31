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
        private myDB bd = new myDB();
        
        // GET: test
        public ActionResult Index()
        {
            List<user> u = bd.users.Where(x => x.user_id == 1).ToList();

           // var result = bd.users.Where(x => x.user_id > 1).Distinct();


            user emp = new user();
            emp.user_id = 145 ;
            emp.password = "Marla";
            emp.user_name = "Sukesh";

            ViewData["Employee"] = emp;
            return View("vm");
        }
        // GET: test
        
    }
}