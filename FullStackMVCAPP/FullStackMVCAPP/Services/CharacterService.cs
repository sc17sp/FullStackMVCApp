using FullStackMVCAPP.DataContext;
using FullStackMVCAPP.DataContext.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FullStackMVCAPP.Models;
using FullStackMVCAPP.Services.Interfaces;

namespace FullStackMVCAPP.Services
{
    public class CharacterService : ICharacterService
    {
        protected readonly GOTContext _GOTContext;
        protected readonly CharacterRepository _CharacterRepository;

        public CharacterService()
        {
            _GOTContext = new GOTContext();
            _CharacterRepository = new CharacterRepository();
        }

        public CharacterService(GOTContext gOTContext)
        {
            _GOTContext = gOTContext;
            _CharacterRepository = new CharacterRepository();
        }

        public IEnumerable<Character> GetCharacters()
        {
            return _CharacterRepository.EntityList(_GOTContext);    
        }

        public Character GetCharacterById(int id)
        {
            return _CharacterRepository.GetEntityByID(_GOTContext, id);
        }

        public IEnumerable<Character> GetCharacterByHouseId(int id)
        {
            return _CharacterRepository.GetCharacterByHouseId(_GOTContext, id);
        }
    }
}