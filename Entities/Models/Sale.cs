using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Sale
    {
        public Guid SaleId { get; set; }
        public Item? Item { get; set; }
        public Service? Service { get; set; }
        public int Quantity { get; set; }
    }
}
