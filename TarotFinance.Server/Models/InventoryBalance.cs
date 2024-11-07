using System.ComponentModel.DataAnnotations;

namespace TarotFinance.Server.Models
{
    public class InventoryBalance
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int InventoryId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int PreviousInventory { get; set; }
        [Required]
        public int Entry { get; set; }
        [Required]
        public int Egress { get; set; }
        [Required]
        public int CurrentInventory { get; set; }
        [Required]
        public int PhysicalInventory { get; set; }
        [Required]
        public int Difference { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public decimal Total { get; set; }
    }
}
