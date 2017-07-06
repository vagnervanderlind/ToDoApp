namespace ToDoApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ToDoApp.DAL;
    using ToDoApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TodoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TodoContext context)
        {
        }
    }
}
