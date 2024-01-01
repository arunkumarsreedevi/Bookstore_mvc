using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bookstore1_mvc.Models;
namespace bookstore1_mvc.Controllers
{
    public class userLoginController : Controller
    {
        db_mvcEntities dbobj = new db_mvcEntities();
        // GET: userLogin
        public ActionResult login_load()
        {
            return View();
        }
        public ActionResult home()
        {
            return View();
        }
        public ActionResult login_click(logindb objcls)
        {
            if (ModelState.IsValid)
            {
                ObjectParameter op = new ObjectParameter("status", typeof(int));//output parameter
                dbobj.sp_blogin(objcls.username, objcls.password, op);
                int val = Convert.ToInt32(op.Value);
                if(val==1)
                {
                    Session["una"] = objcls.username;
                    return RedirectToAction("home");
                }
                else
                {
                    ModelState.Clear();
                    objcls.msg = "invalid";
                    return View("login_load", objcls);
                }
            }
                return View("login_load", objcls);
        }
    }
}