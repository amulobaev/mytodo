using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using MyToDo.Core;
using MyToDo.Data;

namespace MyToDo.Controllers
{
    [Authorize]
    public class TasksController : ApiController
    {
        private readonly IRepository<MyTask> _repository;

        public TasksController(ICustomRepository<MyTask> repository)
        {
            _repository = repository;
        }

        public IEnumerable<MyTask> GetAllTasks()
        {
            var userId = User.Identity.GetUserId();
            var tasks = _repository.GetAll().ToList();
            return tasks;
        }
    }
}
