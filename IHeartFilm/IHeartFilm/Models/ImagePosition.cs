using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IHeartFilm.Models
{
    public class ImagePosition
    {
        public int Id { get; set; }
        public Image Image { get; set; }
        public Position MyProperty { get; set; }
        public int Order { get; set; }
    }
}