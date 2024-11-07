using System.ComponentModel.DataAnnotations;

namespace TarotFinance.Server.Models
{
    public class Inventory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public InventoryType Type { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public decimal GeneralTotal { get; set; }
    }

    public enum InventoryType
    {
        PerUnits,
        PerPackages
    }
}
