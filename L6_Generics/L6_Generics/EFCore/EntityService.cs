namespace L6_Generics.EFCore;

internal class EntityService<T> where T : IEntity, new()
{
    public T GetById(int id)
    {
        return new T();
    }
}
