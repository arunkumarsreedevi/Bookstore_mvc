using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bookstore1_mvc.Models;
namespace bookstore1_mvc.Controllers
{
    public class displayallController : Controller
    {
        db_mvcEntities dbobj = new db_mvcEntities();
        // GET: displayall
        public ActionResult display_all()
        {
            return View(dbobj.tab_book.ToList());
        }
    }
}