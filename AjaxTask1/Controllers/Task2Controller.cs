using AjaxTask1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxTask1.Controllers
{
    public class Task2Controller : Controller
    {
        ISMPracticeEntities2 db = new ISMPracticeEntities2();

        // GET: Task2
        public ActionResult Index()
        {
            ViewBag.result = new SelectList(db.tbl_Registration, "id", "name");
            return View();
        }

        public JsonResult AjaxDropDownSearch(int id)
        {
            return Json(db.tbl_Registration.Find(id), JsonRequestBehavior.AllowGet);
        }
    }
}