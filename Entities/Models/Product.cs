using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public abstract class Product
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public bool IsVisible { get; set; } = true;
        public decimal Price { get; set; }
    }
}