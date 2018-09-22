using System;
using System.Collections.Generic;
using System.Globalization;
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
            var stops = _context.TrackServiceHistory.Take(100).ToList();

            return View(stops);
        }

        // GET: Stops/{year}
        public ActionResult GetStopsByYear(int year)
        {
            var stops = _context.TrackServiceHistory.Where(stop => stop.dRepairDate.Year == year).Take(100).ToList();

            return View("Index", stops);
        }

        // GET: Stops/{year}/{month}
        public ActionResult GetStopsByMonth(int year, int month)
        {
            var stops = _context.TrackServiceHistory.Where(stop => stop.dRepairDate.Year == year && stop.dRepairDate.Month == month).Take(100).ToList();

            return View("Index", stops);
        }

        // GET: Stops/{year}/{month}/{day}
        public ActionResult GetStopsByDay(int year, int month, int day)
        {
            IEnumerable<TrackServiceHistory> stops;

            if (DateTime.TryParse($"{month}/{day}/{year}", CultureInfo.InvariantCulture, DateTimeStyles.None, out var date))
                stops = _context.TrackServiceHistory.ToList()
                    .Where(stop => stop.dRepairDate.Date == date.Date)
                    .Take(100);
            else
                return HttpNotFound("DATE CANNOT BE PARSED!");

            return View("Index", stops);
        }
    }
}