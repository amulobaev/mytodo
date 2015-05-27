using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyToDo.Data.Migrations;

namespace MyToDo.Data
{
    public class MyToDoContext : DbContext
    {
        public MyToDoContext()
            : base("name=MyToDoContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MyToDoContext, Configuration>());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<TaskEntity> Tasks { get; set; }
    }
}
