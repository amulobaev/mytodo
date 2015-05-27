using System;
using System.Linq;
using System.Reflection;

namespace MyToDo.Data
{
    public class EntityTypeResolver : IEntityTypeResolver
    {
        public Type Resolve(Type modelType)
        {
            string typeName = modelType.Name + "Entity";
            Type entityType =
                Assembly.GetExecutingAssembly()
                    .GetTypes()
                    .FirstOrDefault(x => x.IsClass && x.IsSubclassOf(typeof(BaseEntity)) && x.Name.Contains(typeName));
            return entityType;
        }
    }
}