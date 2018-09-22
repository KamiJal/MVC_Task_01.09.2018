using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Task_01._09._2018.Models.MCSDb;

namespace MVC_Task_01._09._2018.Controllers
{
    public class HomeController : Controller
    {

        private MCSDb _context;

        public HomeController()
        {
            _context = new MCSDb();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}