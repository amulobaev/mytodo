using System;
using System.Collections.Generic;

namespace MyToDo.Data
{
    public interface IRepository<T> : IDisposable
    {
        IEnumerable<T> GetAll();

        T GetById(Guid id);

        void Create(T model);

        void Update(T model);

        void Delete(T model);
    }
}