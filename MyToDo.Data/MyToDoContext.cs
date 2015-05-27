using System.Data.Entity;

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
