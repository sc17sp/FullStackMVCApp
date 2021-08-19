using System;

public interface IEntityRepository<T> where T : class
{
    public IList<T> EntityList();
    public T GetEntityByID(int id);
}
