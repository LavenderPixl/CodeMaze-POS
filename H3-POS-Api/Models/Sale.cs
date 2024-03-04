using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H3_POS_Api.Models
{
    public class Sale
    {
        public int SaleId { get; set; }
        public Item? Item { get; set; }
        public Service? Service { get; set; }

        [Required(ErrorMessage = "Quantity is required.")]
        public int Quantity { get; set; }

        [ForeignKey(nameof(Order))]
        public Guid OrderId { get; set; }
        public Order? Order { get; set; }
    }
}
