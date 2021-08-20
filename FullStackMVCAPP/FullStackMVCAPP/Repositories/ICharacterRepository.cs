using FullStackMVCAPP.DataContext;
using FullStackMVCAPP.Repositories.Base;
using System;
using System.Collections.Generic;

namespace FullStackMVCAPP.Repositories
{
public interface ICharacterRepositry: IEntityRepository <FullStackMVCAPP.Models.Character>
{
    IList<FullStackMVCAPP.Models.Character> GetCharacterByHouseId(GOTContext _GOTContext, int id);
}
}
