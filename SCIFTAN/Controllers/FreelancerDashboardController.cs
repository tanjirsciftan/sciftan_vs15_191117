using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SCIFTAN.Controllers
{
    public class FreelancerDashboardController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}