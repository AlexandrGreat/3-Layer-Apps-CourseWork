﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Models
{
    internal class ProductView
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int DiscountPercentage { get; set; }
        public string Category { get; set; }
        public string Provider { get; set; }
    }
}