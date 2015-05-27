using System;

namespace MyToDo.Data
{
    public interface IEntityTypeResolver
    {
        Type Resolve(Type modelType);
    }
}