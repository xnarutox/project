namespace MvcLearning.Migrations
{
    using MvcLearning.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcLearning.Models.MVCLearningDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MvcLearning.Models.MVCLearningDb context)
        {
            context.Restaurants.AddOrUpdate(r => r.Name,
                new RestaurantModels { Name = "TiTi", City = "HCM", Country = "VN" },
                new RestaurantModels { Name = "ZinHon", City = "LA", Country = "USA" },
                new RestaurantModels
                {
                    Name = "Pizza Hut",
                    City = "HN",
                    Country = "VN",
                    Reviews = new List<RestaurantReviewModels> {
                        new RestaurantReviewModels { Rate=7, Body="The pizza is kind of salty.", ReviewerName="ElBi"}
                    }
                });


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
