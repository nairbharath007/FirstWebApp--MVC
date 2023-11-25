using System.ComponentModel.DataAnnotations;

namespace FirstWebApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ProductDescription { get; set; }
    }
}
