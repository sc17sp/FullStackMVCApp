﻿using FullStackMVCAPP.DataContext;
using FullStackMVCAPP.DataContext.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FullStackMVCAPP.Models;
namespace FullStackMVCAPP.Services
{
    public class CharacterService
    {
        protected readonly GOTContext _GOTContext;
        protected readonly CharacterRepository _CharacterRepository;

        public CharacterService()
        {
            _GOTContext = new GOTContext();
            _CharacterRepository = new CharacterRepository();
        }

        public IList<Character> GetCharacters()
        {
            return _CharacterRepository.EntityList(_GOTContext);    
        }

        public Character GetCharacterById(int id)
        {
            return _CharacterRepository.GetEntityByID(_GOTContext, id);
        }

        public IList<Character> GetCharacterByHouseId(int id)
        {
            return _CharacterRepository.GetCharacterByHouseId(_GOTContext, id);
        }
    }
}