﻿using MVCDBfirst.Models;
using MVCDBfirst.Models.ViewModel;
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
            
            List<user> u = ndb.users.Where(x => x.user_id == 1).ToList();

            // var result = bd.users.Where(x => x.user_id > 1).Distinct();

            var id = 0;
            foreach (var i in u)
            {
                id = i.user_id;

            }


            user emp = new user();
            emp.user_id = u[0].user_id;
            emp.password = u[0].password;
            emp.user_name = u[0].user_name;

            ViewData["Employee"] = emp;
          


            return View();
        }
        public ActionResult GetEmpData()
        {

            List<user> u = ndb.users.Where(x => x.user_id == 1).ToList();

            // var result = bd.users.Where(x => x.user_id > 1).Distinct();

            var id = 0;
            foreach (var i in u)
            {
                id = i.user_id;

            }


            emp e= new emp();
            e.emp_id = u[0].user_id;
            e.pass = u[0].password;
            e.us_name = u[0].user_name;

            



            return View(e);
        }
    }
    
}