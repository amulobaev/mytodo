using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyToDo.Core;

namespace MyToDo.Models
{
    public class HomeModel
    {
        private readonly List<MyTask> _tasks = new List<MyTask>();

        public HomeModel()
        {
        }

        public List<MyTask> Tasks
        {
            get { return _tasks; }
        }
    }
}