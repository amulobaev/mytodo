using System.Data.Entity.Migrations;

namespace MyToDo.Data
{
    internal sealed class Configuration : DbMigrationsConfiguration<MyToDoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
