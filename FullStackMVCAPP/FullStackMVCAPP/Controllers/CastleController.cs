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
        // GET: Castle
        public ActionResult Index()
        {
            GOTContext  context = new DataContext.GOTContext();
            CastleRepository castleRepository = new CastleRepository();

            CastleService castleService = new CastleService(context, castleRepository);

            return View(castleService.GetCastles());
        }
    }
}