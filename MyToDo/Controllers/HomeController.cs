using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyToDo.Core;
using MyToDo.Data;
using MyToDo.Models;

namespace MyToDo.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IRepository<MyTask> _repository;

        public HomeController(ICustomRepository<MyTask> repository)
        {
            _repository = repository;
        }

        // GET: Home
        public ActionResult Index()
        {
            HomeModel model = new HomeModel();
            List<MyTask> tasks = _repository.Query().OrderBy(x => x.Created).ToList();
            //List<MyTask> tasks = _repository.GetAll().OrderBy(x => x.Created).ToList();
            model.Tasks.AddRange(tasks);
            return View(model);
        }
    }
}