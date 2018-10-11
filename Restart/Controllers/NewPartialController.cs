using Restart.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restart.Controllers
{
    public class NewPartialController : Controller
    {
        // GET: NewPartial
        UsersEntities db = new UsersEntities();
        
       
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Form(tbl_Users u)
        {
            if (ModelState.IsValid)
            {
                //db.tbl_Users.Add(u);
                //db.SaveChanges();
                return RedirectToAction("Display");

            }
            return PartialView();
        }
        public ActionResult Form_Save(tbl_Users u)
        {
           
            if (ModelState.IsValid)
            {
                db.tbl_Users.Add(u);
                db.SaveChanges();
                return RedirectToAction("Display",u);

            }
            return PartialView();
        }

        public ActionResult Display(tbl_Users u)
        {
            u.SlNo = u.SlNo != null ? u.SlNo : 0;
            u.UserName = u.UserName != null ? u.UserName : "";
            u.EmailId = u.EmailId != null ? u.EmailId : "";
            u.Password = u.Password != null ? u.Password : "";
            u.ConfirmPassword = u.ConfirmPassword != null ? u.ConfirmPassword : "";
            return PartialView(u);
        }
        public ActionResult Save()
        {
            return PartialView();
        }
    }
}