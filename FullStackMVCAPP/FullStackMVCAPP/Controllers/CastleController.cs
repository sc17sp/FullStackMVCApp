﻿using FullStackMVCAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FullStackMVCAPP.Controllers
{
    public class CastleController : Controller
    {
        // GET: Castle
        public ActionResult Index()
        {
            using (var db = new GOTContext()) 
            {
                var castleList = db.Castles.ToList();
                return View(castleList);
            }
        }
    }
}