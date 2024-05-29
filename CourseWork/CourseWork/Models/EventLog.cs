using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Models
{
    internal class EventLog
    {
        public int ID { get; set; }
        public string EventType { get; set; }
        public string EventTable { get; set; }
        public int Rows { get; set; }
        public string DateTime { get; set; }
    }
}
