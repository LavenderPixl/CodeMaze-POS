using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class ServiceCategory
    {
        public Guid ServiceCategoryId { get; set; }
        public string Name { get; set; }
        public List<ServiceSubCategory> ServiceSubCategories { get; set; }
    }
}
