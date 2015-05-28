using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MyToDo.Core;

namespace MyToDo.Data
{
    public class TaskRepository : ICustomRepository<MyTask>
    {
        static TaskRepository()
        {
            Mapper.CreateMap<MyTask, TaskEntity>();
            Mapper.CreateMap<TaskEntity, MyTask>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => (Status)src.Status));
        }

        public IEnumerable<MyTask> GetAll()
        {
            using (MyToDoContext context = new MyToDoContext())
            {
                List<TaskEntity> entities = context.Tasks.ToList();
                List<MyTask> models = Mapper.Map<List<TaskEntity>, List<MyTask>>(entities);
                return models;
            }
        }

        public IQueryable<MyTask> Query()
        {
            MyToDoContext context = new MyToDoContext();
            return context.Tasks.AsQueryable().Project().To<MyTask>();
        }

        public MyTask GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Create(MyTask model)
        {
            throw new NotImplementedException();
        }

        public void Update(MyTask model)
        {
            throw new NotImplementedException();
        }

        public void Delete(MyTask model)
        {
            throw new NotImplementedException();
        }
    }
}