using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class LineItem
    {
        public int LineItemId { get; set; }
        public int Quantity { get; set; }

        // Constructor
        public LineItem()
        {
            Quantity = 1; // Any default values are best to set in the constructor
        }


        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}
