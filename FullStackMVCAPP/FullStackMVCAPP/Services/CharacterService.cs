using FullStackMVCAPP.DataContext;
using FullStackMVCAPP.DataContext.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FullStackMVCAPP.Services
{
    public class CharacterService
    {
        protected readonly GOTContext _GOTContext;
        protected readonly CharacterRepository _CharacterRepository;

        public CharacterService(GOTContext gOTContext, CharacterRepository characterRepository)
        {
            _GOTContext = gOTContext;
            _CharacterRepository = characterRepository;
        }

        public IList<FullStackMVCAPP.Models.Character> GetCharacters()
        {
            return _CharacterRepository.EntityList(_GOTContext);    
        }

        public FullStackMVCAPP.Models.Character GetCharacterById(int id)
        {
            return _CharacterRepository.GetEntityByID(_GOTContext, id);
        }

        public IList<FullStackMVCAPP.Models.Character> GetCharacterByHouseId(int id)
        {
            return _CharacterRepository.GetCharacterByHouseId(_GOTContext, id);
        }
    }
}