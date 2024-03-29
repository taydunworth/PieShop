﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PieShop.Model
{
    public class Pie
    {
        public int Id { get; set; }
        public string PieName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public bool InStock { get; set; }
    }
}
