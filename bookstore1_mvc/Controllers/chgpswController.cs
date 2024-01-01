using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bookstore1_mvc.Models;
namespace bookstore1_mvc.Controllers
{
    public class chgpswController : Controller
    {
        db_mvcEntities dbobj = new db_mvcEntities();
        // GET: chgpsw
        public ActionResult ps_load()
        {
            return View();
        }
        public ActionResult ps_click(cgpswcls objcls)
        {
            if (ModelState.IsValid)
            {
                ObjectParameter op = new ObjectParameter("status", typeof(int));//output parameter
                dbobj.sp_bpswchange1(Session["una"].ToString(), objcls.oldpsw, objcls.newpsw, op);
                int val = Convert.ToInt32(op.Value);
                if (val == 1)
                {
                    objcls.msg = "password changed";
                    return View("psw_load", objcls);
                }
                else
                {

                    objcls.msg = "invalid";
                    return View("psw_load", objcls);
                }
            }
                return View("psw_load", objcls);
            }
        }
    }
