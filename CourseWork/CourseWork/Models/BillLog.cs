using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Models
{
    internal class BillLog
    {
        public int ID { get; set; }
        public int Seller { get; set; }
        public string Date { get; set; }
        public string Total { get; set; }
    }
}
