using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcLearning.Models
{
    public class MVCLearningDb : DbContext
    {
        public MVCLearningDb() : base("name=DefaultConnection")
        { 
    
        }
        public DbSet<RestaurantModels> Restaurants { get; set; }
        public DbSet<RestaurantReviewModels> RestaurantReviews { get; set; }
    }
}