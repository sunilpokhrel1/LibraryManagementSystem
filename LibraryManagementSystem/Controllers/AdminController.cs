using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class AdminController : Controller
    {


        private AdminEntity adminDb = new AdminEntity();

        //  Admin Login Page .
        [HttpGet]
        [HandleError]
        public ActionResult Login()
        {
            return View();
        }

        //gets the value from admin login page and checks the values. 
        [HttpPost]
        [HandleError]
        public ActionResult Login(tblAdmin admin)
        {
            var adm = adminDb.tblAdmins.SingleOrDefault(a => a.AdminEmail == admin.AdminEmail && a.AdminPass == admin.AdminPass);
            if (adm != null)
            {
                int id = adm.AdminId;
                Session["adminId"] = adm.AdminId;
                Session["adminName"] = adm.AdminName;


                return RedirectToAction("Dashbord", "DashBord" , new { id = id });
            }
            else if (admin.AdminEmail == null && admin.AdminPass == null)
            {
                return View();
            }
            ViewBag.Message = "User name and password are not matching";
            return View();
        }
 

        // Admin logout, redirect to main. 
        [HandleError]

        public ActionResult Logout()
        {
            Session.Remove("adminId");
            return RedirectToAction("Login");
        }

    }
}
