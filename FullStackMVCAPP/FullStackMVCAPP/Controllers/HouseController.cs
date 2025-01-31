﻿using FullStackMVCAPP.DataContext;
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
        private readonly HouseService _HouseService;

        public HouseController() 
        {
            _HouseService = new HouseService();
        }
        // GET: House
        public ActionResult Index()
        {
            var listOfHouses = _HouseService.GetHouses();
            return View(listOfHouses);
        }

        // GET: House/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

    }
}
