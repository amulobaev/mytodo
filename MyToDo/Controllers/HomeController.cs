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
    public class HomeController : Controller
    {
        private readonly IRepository<Task> _repository;

        public HomeController(IGenericRepository<Task> repository)
        {
            _repository = repository;
        }

        // GET: Home
        public ActionResult Index()
        {
            HomeModel model = new HomeModel();
            //List<Task> tasks = _repository.Query().OrderBy(x => x.Created).ToList();
            List<Task> tasks = _repository.GetAll().OrderBy(x => x.Created).ToList();
            model.Tasks.AddRange(tasks);
            return View(model);
        }
    }
}