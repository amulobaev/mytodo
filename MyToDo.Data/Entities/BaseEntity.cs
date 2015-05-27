using System;
using System.ComponentModel.DataAnnotations;

namespace MyToDo.Data
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
