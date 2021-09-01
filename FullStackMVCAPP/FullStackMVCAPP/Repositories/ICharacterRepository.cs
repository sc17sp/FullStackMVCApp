using FullStackMVCAPP.DataContext;
using FullStackMVCAPP.Repositories.Base;
using System;
using System.Collections.Generic;
using FullStackMVCAPP.Models;

namespace FullStackMVCAPP.Repositories
{
public interface ICharacterRepositry: IEntityRepository <Character>
{
    IEnumerable<Character> GetCharacterByHouseId(GOTContext _GOTContext, int id);
}
}
