using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC5HomeWork1.Models;

namespace MVC5HomeWork1.Controllers
{
    public class CustCountsController : Controller
    {
        private 客戶資料Entities db = new 客戶資料Entities();

        // GET: CustCounts
        public ActionResult Index()
        {
            return View(db.ViewCustCount.ToList());
        }

        public ActionResult IndexById(int id)
        {
            return View("Index", db.ViewCustCount.Where(p=>p.Id==id).ToList());
            //return View(db.ViewCustCount.ToList());
        }
    }
}
