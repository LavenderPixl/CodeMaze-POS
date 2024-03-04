using System.ComponentModel.DataAnnotations;

namespace H3_POS_Api.Models
{
    public class ServiceSubCategory
    {
        public int ServiceSubCategoryId { get; set; }
        
        [Required(ErrorMessage = "A list of Services is required.")]
        public List<Service> Services { get; set; }
    }
}
