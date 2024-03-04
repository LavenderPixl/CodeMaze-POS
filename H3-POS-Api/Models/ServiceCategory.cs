using System.ComponentModel.DataAnnotations;

namespace H3_POS_Api.Models
{
    public class ServiceCategory
    {
        public int ServiceCategoryId { get; set; }

        [Required(ErrorMessage = "A list of Service Sub Categories is required.")]
        public List<ServiceSubCategory> ServiceSubCategories { get; set; }
    }
}
