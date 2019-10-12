using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace technology_tp1.Models
{
    public struct CartItem
    {
        public MenuItem MenuItem { get; }
        public int Quantity { get; }

        public CartItem(MenuItem item, int quantity)
        {
            MenuItem = item;
            Quantity = quantity;
        }
    }
}
