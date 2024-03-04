using System.ComponentModel.DataAnnotations;

namespace H3_POS_Api.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(70, ErrorMessage = "Name cannot be longer than 70 characters.")]
        public string Name { get; set; } = "";
        [Required(ErrorMessage = "A Description is required.")]
        public string Description { get; set; } = "";

        [Required(ErrorMessage = "Visibility needs to be decided.")]
        public bool IsVisible { get; set; } = true;
        [Required(ErrorMessage = "A price is required.")]
        public decimal Price { get; set; }
    }
}
