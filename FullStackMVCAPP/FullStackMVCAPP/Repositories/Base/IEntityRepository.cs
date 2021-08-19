using System;

namespace FullStackMVCAPP.Repositories.Base
{
public interface IEntityRepository<T> where T : class
{
    public IList<T> EntityList();
    public T GetEntityByID(int id);
}
}
