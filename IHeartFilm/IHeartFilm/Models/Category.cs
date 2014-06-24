using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IHeartFilm.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Position Position { get; set; }
    }
}