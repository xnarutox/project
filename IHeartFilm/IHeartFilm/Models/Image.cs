using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IHeartFilm.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}