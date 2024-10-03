using System.ComponentModel.DataAnnotations;

namespace Sales_OOP.Entity
{
    public class Cathegory
    {
        [Key]
        public int CathergoryId { get; set; }
        public string CathergoryName { get; set; }
    }
}
