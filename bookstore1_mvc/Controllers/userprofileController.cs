using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bookstore1_mvc.Models;
namespace bookstore1_mvc.Controllers
{
    public class userprofileController : Controller
    {
        db_mvcEntities dbobj = new db_mvcEntities();
        // GET: userprofile
        public ActionResult profile_load()
        {
            var getdata = dbobj.sp_bprofile(Session["una"].ToString()).FirstOrDefault();
            return View(new profileviewandedit
            {
                name=getdata.name,
                details=getdata.details,
                price=getdata.price
            }
                );
        }
        public ActionResult profile_update(profileviewandedit objcls)
        {
            dbobj.sp_bprofile_update(Session["una"].ToString(), objcls.name, objcls.details, objcls.price);
            var getdata = dbobj.sp_bprofile(Session["una"].ToString()).FirstOrDefault();
            return View("profile_load", new profileviewandedit
            {
                name = getdata.name,
                details = getdata.details,
                price = getdata.price
            }
                );
        }
        
        }
}