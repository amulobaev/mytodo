using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyToDo.Data;
using Ninject.Modules;

namespace MyToDo
{
    public class MyNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IEntityTypeResolver>().To<EntityTypeResolver>();
            Bind(typeof(IRepository<>)).To(typeof(EfRepository<>));
        }
    }
}