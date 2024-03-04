using System.ComponentModel.DataAnnotations;

namespace H3_POS_Api.Models
{
    public class Service : Product
    {
        [Required(ErrorMessage = "Time Required(Minutes) is required.")]
        public int TimeRequiredMinutes { get; set; }
    }
}
