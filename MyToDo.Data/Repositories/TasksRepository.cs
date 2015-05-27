using System;
using System.Collections.Generic;
using System.Linq;
using MyToDo.Core;

namespace MyToDo.Data
{
    public class TasksRepository : ICustomRepository<Task>
    {
        

        public IEnumerable<Task> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Task> Query()
        {
            throw new NotImplementedException();
        }

        public Task GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Create(Task model)
        {
            throw new NotImplementedException();
        }

        public void Update(Task model)
        {
            throw new NotImplementedException();
        }

        public void Delete(Task model)
        {
            throw new NotImplementedException();
        }
    }
}