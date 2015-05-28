using System;
using System.ComponentModel.DataAnnotations;

namespace MyToDo.Data
{
    /// <summary>
    /// Базовый класс для сущностей Entity Framework
    /// </summary>
    internal class BaseEntity
    {
        /// <summary>
        /// Уникальный идентификатор, первичный ключ
        /// </summary>
        [Key]
        public Guid Id { get; set; }
    }
}
