using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FullStackMVCAPP.DataContext.Repositories
{
    public class CharacterRepository: EntityRepository <FullStackMVCAPP.Models.Character>, ICharacterRepositroy
    {
        public CharacterRepository(GOTContext gameOfThronesContext){}

        public IList<FullStackMVCAPP.Models.Character> GetCharacterByHouseId(int id)
        {
            return _GOTContext.Characters.Where(Chr => Chr.id == id).ToList();
        }
    }
}