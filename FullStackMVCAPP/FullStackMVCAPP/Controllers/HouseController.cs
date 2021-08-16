using FullStackMVCAPP.Models;
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
            using (var db = new GOTContext()) 
            {
                var housesList = db.Houses.ToList();
                var castleList = db.Castles.ToList();


                return View(housesList);

            }
        }

        // GET: House/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

    }
}
