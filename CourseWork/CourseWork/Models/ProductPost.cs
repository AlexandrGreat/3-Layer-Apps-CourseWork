using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Models
{
    internal class ProductPost
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int DiscountPercentage { get; set; }
        public int Category { get; set; }
        public int Provider { get; set; }
    }
}
