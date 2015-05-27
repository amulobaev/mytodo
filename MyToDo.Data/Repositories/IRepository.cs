using System;
using System.Collections.Generic;
using System.Linq;

namespace MyToDo.Data
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();

        IQueryable<T> Query();

        T GetById(Guid id);

        void Create(T model);

        void Update(T model);

        void Delete(T model);
    }
}