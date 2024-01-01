using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bookstore1_mvc.Models;
namespace bookstore1_mvc.Controllers
{
    public class RegisterController : Controller
    {
        db_mvcEntities dbobj = new db_mvcEntities();
        // GET: Register
        public ActionResult reg_load()
        {
            return View();
        }
        public ActionResult reg_click(insertdb objcls)//if fiule upload here  public ActionResult reg_click(insertdb objcls,HttppostedfileBase file)
        {
            if(ModelState.IsValid)
            {
                //if(file.contentLength>0)
                //    {
                //        string fname = Path.GetFileName(file.Filename);
                //        var s = Server.MapPath("~/phs");
                //        string pa = Path.Combine(s, fname);
                //        file.SaveAs(pa);
                //        var fullpath = Path.Combine("~//phs", fname);
                //        objcls.photo = fulpath;

                //    }
                //get
                dbobj.sp_binsert(objcls.name, objcls.details, objcls.price, objcls.username, objcls.password);
                objcls.msg = "success";
                return View("reg_load",objcls);

            }
            return View("reg_load",objcls); 
        }
    }
}