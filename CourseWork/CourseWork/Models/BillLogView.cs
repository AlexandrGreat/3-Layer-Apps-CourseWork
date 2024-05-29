using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Models
{
    internal class BillLogView
    {
        public int ID { get; set; }
        public string Seller { get; set; }
        public string Date { get; set; }
        public string Total { get; set; }
    }
}
