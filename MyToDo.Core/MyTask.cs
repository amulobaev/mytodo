using System;

namespace MyToDo.Core
{
    /// <summary>
    /// Задача
    /// </summary>
    public class MyTask : BaseModel
    {
        public MyTask()
        {
        }

        public MyTask(Guid id)
        {
            Id = id;
        }

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
        public Status Status { get; set; }

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