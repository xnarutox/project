using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IHeartFilm.Models
{
    public class IHeartFilmDb : DbContext
    {
        public IHeartFilmDb()
            : base("name=DefaultConnection")
        { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<ImagePosition> ImagePositions { get; set; }
    }
}