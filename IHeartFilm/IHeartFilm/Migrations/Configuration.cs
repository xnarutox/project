namespace IHeartFilm.Migrations
{
    using IHeartFilm.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IHeartFilm.Models.IHeartFilmDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(IHeartFilm.Models.IHeartFilmDb context)
        {
            //context.Positions.AddOrUpdate(r => r.Name,
            //    new Position { Name = "pos-banner" },
            //    new Position { Name = "pos-1" },
            //    new Position { Name = "pos-2" },
            //    new Position { Name = "pos-3" },
            //    new Position { Name = "pos-4" }
            //    );
            //context.Categories.AddOrUpdate(r => r.Name,
            //    new Category { Name = "Banner", Position = new Position { Name = "pos-banner" } },
            //    new Category { Name = "New Videos", Position = new Position { Name = "pos-1" } },
            //    new Category { Name = "Popolar", Position = new Position { Name = "pos-2" } },
            //    new Category { Name = "American Movies", Position = new Position { Name = "pos-3" } },
            //    new Category { Name = "Korean Dramas", Position = new Position { Name = "pos-4" } }
            //    );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
