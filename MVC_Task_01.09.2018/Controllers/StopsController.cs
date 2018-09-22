using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Task_01._09._2018.Models.MCSDb;

namespace MVC_Task_01._09._2018.Controllers
{
    public class StopsController : Controller
    {
        private MCSDb _context;

        public StopsController()
        {
            _context = new MCSDb();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Stops
        public ActionResult Index()
        {
            return View();
        }
    }
}