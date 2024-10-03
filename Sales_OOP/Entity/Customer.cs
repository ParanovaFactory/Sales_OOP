using System.ComponentModel.DataAnnotations;

namespace Sales_OOP.Entity
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCity { get; set; }
    }
}
