﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IHeartFilm.Models
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category cate { get; set; }
    }
}