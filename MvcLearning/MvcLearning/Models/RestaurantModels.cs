﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLearning.Models
{
    public class RestaurantModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public ICollection<RestaurantReviewModels> Reviews { get; set; }
    }
}