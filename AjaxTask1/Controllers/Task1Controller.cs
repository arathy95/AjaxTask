using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using AjaxTask1.Models;
using System.Runtime.Remoting.Contexts;

namespace AjaxTask1.Controllers
{
    public class Task1Controller : Controller
    {
        //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-D2RS25A9\SQLEXPRESS;Initial Catalog=AjaxTask1;Integrated Security=True");
        AjaxTask1Entities db = new AjaxTask1Entities();

        // GET: Task1
        public ActionResult index()
        {
            return View();
        }

        public ActionResult AjaxTextboxSearch()
        {
            var data = db.Task1.ToList();
            ViewBag.result = data;
            return View();
        }
    }
}