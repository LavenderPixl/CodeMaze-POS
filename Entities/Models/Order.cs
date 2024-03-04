using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public bool Completed { get; set; }
        public DateTime Date { get; set; }
        public List<Sale> Sales { get; set; } = new();
    }
}
