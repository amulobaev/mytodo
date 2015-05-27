using System;

namespace MyToDo.Data
{
    /// <summary>
    /// Интерфейс репозитария с привязками
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface IInternalRepository<T> : IRepository<T>
    {
        /// <summary>
        /// Создание привязок
        /// </summary>
        void CreateMappings();
    }
}