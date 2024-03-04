using System.ComponentModel.DataAnnotations;

namespace H3_POS_Api.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required(ErrorMessage = "A confirmation of sale is required (Boolean).")]
        public bool Completed { get; set; }

        [Required(ErrorMessage = "A Date is required.")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "A List of sales, is required.")]
        public List<Sale> Sales { get; set; } = new();
    }
}
