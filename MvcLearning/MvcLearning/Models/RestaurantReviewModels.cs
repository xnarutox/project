using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLearning.Models
{
    public class RestaurantReviewModels
    {
        public int Id { get; set; }
        public int Rate { get; set; }
        public string Body { get; set; }
        public string ReviewerName { get; set; }
        public int RestaurantId { get; set; }
    }
}