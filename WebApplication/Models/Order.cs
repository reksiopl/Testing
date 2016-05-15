namespace WebApplication.Models
{
    public class Order
    {
        public int id { get; set; }
        public string name { get; set; }
        public string street { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string country { get; set; }
        public bool giftwrap { get; set; }
        public Product[] products { get; set; }
    }
}