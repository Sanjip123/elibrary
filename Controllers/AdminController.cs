using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using elibrary;

namespace elibrary.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(user_table usr)
        {
            //get username and password from the user
            //check it against the database user table

            Entities3 dbObject = new Entities3();
            var checkUser = dbObject.user_tables .Where(l => l.user_name.Equals(usr.user_name) && l.user_password.Equals(usr.user_password)).FirstOrDefault();
            if(checkUser!=null)
            {
                var loggeduser = dbObject.user_tables.Where(l => l.user_name.Equals(usr.user_name)).FirstOrDefault();
                Session["user_name"] = loggeduser.user_name.ToString();
                Session["u_id"] = loggeduser.u_id.ToString();
                Session["user_type"] = loggeduser.user_type.ToString();


                return RedirectToAction("Dashboard");
            }
            else
            {
                ViewBag.msg = "Invalid Username or Password";
            }
            return View();
        }
        public ActionResult Dashboard()
        {
            return View();
        }


    }
}