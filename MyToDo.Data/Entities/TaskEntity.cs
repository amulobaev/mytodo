using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyToDo.Data
{
    [Table("Tasks")]
    public class TaskEntity : BaseEntity
    {
        /// <summary>
        /// Наименование
        /// </summary>
        [Required]
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