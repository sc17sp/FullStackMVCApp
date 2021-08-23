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

    public class CharacterController : Controller
    {
        protected readonly CharacterService _CharacterService;

        public CharacterController() 
        {
            _CharacterService = new CharacterService();
        }
        // GET: Character
        public ActionResult HouseCharactersIndex(int id)
        {
            var characterByHouse = _CharacterService.GetCharacterByHouseId(id);
            return View(characterByHouse);
        }
    }
}