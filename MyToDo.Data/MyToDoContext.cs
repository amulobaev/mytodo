using System.Data.Entity;

namespace MyToDo.Data
{
    internal class MyToDoContext : DbContext
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

        public DbSet<UserEntity> Users { get; set; }
    }
}
