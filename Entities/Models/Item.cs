using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Item : Product
    {
        public int StockAmount { get; set; }
    }
}
