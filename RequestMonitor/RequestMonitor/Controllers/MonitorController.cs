using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RequestMonitor.Controllers
{
    public class MonitorController : Controller
    {
        // GET: Monitor
        public ActionResult Index()
        {
            var requestLogs = RequestMonitorApiController.requestLogs;
            return View(requestLogs); // Pass the data to the Razor View

        }
    }
}