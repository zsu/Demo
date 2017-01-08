using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimezoneDetector;
namespace Demo.Controllers
{
	public class TimezoneDetectorController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.ClientTime = DateTime.UtcNow.ToClientTime();
			return View();
		}
	}
}