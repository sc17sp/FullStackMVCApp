using FullStackMVCAPP.DataContext;
using FullStackMVCAPP.DataContext.Repositories;
using FullStackMVCAPP.Models;
using FullStackMVCAPP.Services;
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
            GOTContext context = new DataContext.GOTContext();
            HouseRepository houseRepository = new HouseRepository();

            HouseService houseService = new HouseService(context, houseRepository);
            return View(houseService.GetHouses());
        }

        // GET: House/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

    }
}
