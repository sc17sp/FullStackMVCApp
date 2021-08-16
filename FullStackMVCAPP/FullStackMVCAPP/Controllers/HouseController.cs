using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FullStackMVCAPP.Controllers
{
    public class HouseController : Controller
    {
        // GET: House
        public ActionResult Index()
        {
            return View();
        }

        // GET: House/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

    }
}
