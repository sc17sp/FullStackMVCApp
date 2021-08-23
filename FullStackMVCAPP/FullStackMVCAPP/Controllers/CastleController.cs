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
    public class CastleController : Controller
    {   
        protected readonly CastleService _CastleService;

        public CastleController()
        {
            _CastleService = new CastleService();
        }
        // GET: Castle
        public ActionResult Index()
        {
            var listOfCastles = _CastleService.GetCastles();
            return View(listOfCastles);
        }
    }
}