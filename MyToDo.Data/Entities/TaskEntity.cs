using System;

namespace MyToDo.Data
{
    public class TaskEntity : BaseEntity
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Текст
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Срок создания
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Срок выполнения
        /// </summary>
        public DateTime Deadline { get; set; }
    }
}