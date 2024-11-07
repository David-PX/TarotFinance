using System.ComponentModel.DataAnnotations;

namespace TarotFinance.Server.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "The name is required")]
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Required(ErrorMessage = "The product type is required")]
        public ProductType Type { get; set; }
        [Required(ErrorMessage = "The lot is required")]
        public int Lot { get; set; }
        [Required(ErrorMessage = "The stock is required")]
        public int Stock { get; set; }
        [Required(ErrorMessage = "The price is required")]
        public decimal Price { get; set; }
    }

    public enum ProductType
    {
        Unit,
        Package
    }
}
