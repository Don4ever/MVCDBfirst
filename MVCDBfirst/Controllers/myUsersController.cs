using MVCDBfirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDBfirst.Controllers
{
    public class myUsersController : Controller
    {
        private myDB ndb = new myDB();
        // GET: myUsers
        public ActionResult Index()
        {
            List<user> us = new List<user>();
            us = (from n in ndb.users select n).ToList();


            return View(us);
        }
    }
}