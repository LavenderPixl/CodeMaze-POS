using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class ServiceSubCategory
    {
        public Guid ServiceSubCategoryId { get; set; }
        public string Name { get; set; }
        public List<Service> Services { get; set; }
    }
}
