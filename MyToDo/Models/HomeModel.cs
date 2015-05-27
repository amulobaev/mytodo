using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyToDo.Core;

namespace MyToDo.Models
{
    public class HomeModel
    {
        private readonly List<Task> _tasks = new List<Task>();

        public HomeModel()
        {
        }

        public List<Task> Tasks
        {
            get { return _tasks; }
        }
    }
}