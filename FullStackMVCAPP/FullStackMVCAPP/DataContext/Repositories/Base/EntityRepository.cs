using System;
using FullStackMVCAPP.Repositories.Base;

namespace FullStackMVCAPP.DataContext.Repositories.Base
{
public class EntityRepositories <T> : IEntityRepository <T> where T: class 
{
    protected readonly GOTContext _GOTContext;

    public EntityRepositories(GOTContext gameOfThronesContext)
    {
        _GOTContext = gameOfThronesContext;
    }

    public IList<T> EntityList()
    {
        return _GOTContext.Set<T>.ToList();
    }

    public T GetEntityById(int id)
    {
        return _GOTContext.Set<T>.Where(ent => ent.Id == id);
    }
}
}
