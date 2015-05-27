using System;
using System.Collections.Generic;

namespace MyToDo.Data
{
    /// <summary>
    /// Базовый обобщенный репозитарий
    /// </summary>
    /// <typeparam name="T">Тип объекта</typeparam>
    public abstract class BaseRepository<T> : IRepository<T>
    {
        /// <summary>
        /// Контекст Entity Framework
        /// </summary>
        protected readonly MyToDoContext Context;

        /// <summary>
        /// Конструктор
        /// </summary>
        protected BaseRepository()
        {
            Context = new MyToDoContext();
        }

        public abstract IEnumerable<T> GetAll();

        public abstract T GetById(Guid id);

        public abstract void Create(T model);

        public abstract void Update(T model);

        public abstract void Delete(T model);

        /// <summary>
        /// Зачистка
        /// </summary>
        public void Dispose()
        {
            if (Context != null)
                Context.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}