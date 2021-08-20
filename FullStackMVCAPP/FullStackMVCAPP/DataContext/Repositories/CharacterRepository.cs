using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FullStackMVCAPP.Repositories;
using FullStackMVCAPP.Repositories.Base;

namespace FullStackMVCAPP.DataContext.Repositories
{
    public class CharacterRepository: IEntityRepository<FullStackMVCAPP.Models.Character>, ICharacterRepositry
    {


        public IList<FullStackMVCAPP.Models.Character> EntityList(GOTContext _GOTContext)
        {
            return _GOTContext.Characters.ToList();
        }

        public FullStackMVCAPP.Models.Character GetEntityByID(GOTContext _GOTContext, int id)
        {
            return _GOTContext.Characters.Where(chr => chr.Id == id).First();
        }

        public IList<FullStackMVCAPP.Models.Character> GetCharacterByHouseId(GOTContext _GOTContext, int id)
        {
            var house = _GOTContext.Houses.Where(hos => hos.Id == id);
            return _GOTContext.Characters.Where(chr => chr.HouseID == house).ToList();
        }
    }
}