namespace CourseWorkAPI.Models
{
    public class EventLog
    {
        public int ID { get; set; }
        public string EventType { get; set; }
        public string EventTable { get; set; }
        public int Rows { get; set; }
        public string DateTime { get; set; }
    }
}
