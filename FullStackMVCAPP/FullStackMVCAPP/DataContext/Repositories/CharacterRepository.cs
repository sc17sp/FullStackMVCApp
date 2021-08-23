using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FullStackMVCAPP.Repositories;
using FullStackMVCAPP.Repositories.Base;
using FullStackMVCAPP.Models;
namespace FullStackMVCAPP.DataContext.Repositories
{
    public class CharacterRepository: IEntityRepository<Character>, ICharacterRepositry
    {
        public IEnumerable<Character> EntityList(GOTContext _GOTContext)
        {
            return _GOTContext.Characters.ToList();
        }

        public Character GetEntityByID(GOTContext _GOTContext, int id)
        {
            return _GOTContext.Characters.Single(chr => chr.Id == id);
        }

        public IEnumerable<Character> GetCharacterByHouseId(GOTContext _GOTContext, int id)
        {
            // house used by cshtml to display house name at the top of page see HouseCharactersIndex.cshtml line 7
            var house = _GOTContext.Houses.Where(hos => hos.Id == id).First();
            return _GOTContext.Characters.Where(chr => chr.HouseId.Id == id).ToList();
        }
    }
}