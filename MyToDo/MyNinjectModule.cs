using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyToDo.Core;
using MyToDo.Data;
using Ninject.Modules;

namespace MyToDo
{
    public class MyNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IEntityTypeResolver>().To<EntityTypeResolver>();
            Bind(typeof(IGenericRepository<>)).To(typeof(GenericEfRepository<>));
            Bind<ICustomRepository<MyTask>>().To<TaskRepository>();
        }
    }
}