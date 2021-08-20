using FullStackMVCAPP.DataContext;
using System;
using System.Collections.Generic;

namespace FullStackMVCAPP.Repositories.Base
{
public interface IEntityRepository<T> where T : class
{
    IList<T> EntityList(GOTContext gameOfThronesContext);
    T GetEntityByID(GOTContext gameOfThronesContext,int id);
}
}
