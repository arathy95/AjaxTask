using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxTask1.Models;

namespace AjaxTask1.Controllers
{
    public class Task3Controller : Controller
    {
        AjaxTask1Entities1 objdb = new AjaxTask1Entities1();
        // GET: Task3
        public ActionResult Index()
        {
            List<tbl_Department> deptlist = objdb.tbl_Department.ToList();
            ViewBag.deptlist = new SelectList(deptlist, "deptid", "deptname");
            return View();
        }

        public JsonResult GetSubdeptList(int deptid)
        {
            objdb.Configuration.ProxyCreationEnabled = false;
            List<tbl_SubDepartment> subdeptlist = objdb.tbl_SubDepartment.Where(a => a.FKdeptid == deptid).ToList();
            return Json(subdeptlist, JsonRequestBehavior.AllowGet);
        }
    }
}