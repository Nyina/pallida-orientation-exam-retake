using System.ComponentModel.DataAnnotations;

namespace Webshop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(80)]
        public string ItemName { get; set; }
        [MaxLength(30)]
        public string Manufacturer { get; set; }
        [MaxLength(30)]
        public string Category { get; set; }
        [MaxLength(4)]
        public string Size { get; set; }
        public int Price { get; set; }
    }
}
