namespace CourseWorkAPI.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int DiscountPercentage { get; set; }
        public int Category { get; set; }
        public int Provider { get; set; }
    }
}
