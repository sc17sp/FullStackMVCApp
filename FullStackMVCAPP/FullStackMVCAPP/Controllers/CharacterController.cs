using FullStackMVCAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FullStackMVCAPP.Controllers
{
    public class CharacterController : Controller
    {
        // GET: Character
        public ActionResult HouseCharactersIndex(int id)
        {
            return View();
        }
    }
}