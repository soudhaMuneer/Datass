﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Domain
{
    public class Movie
    {
        public int id { get; set; }
        public string? Name { get; set; }
        public Decimal ?Cost { get; set; }
    }
}
