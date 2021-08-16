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
            using (var db = new GOTContext()) 
            {
                var characterList = db.Characters.Where(chr => chr.HouseID.Id == id).ToList();
                var house = db.Houses.Where(hos => hos.Id == id).ToList();
                return View(characterList);
            }
        }
    }
}