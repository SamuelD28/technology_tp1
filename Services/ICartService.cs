using System.Collections.Generic;
using technology_tp1.Models;

namespace technology_tp1.Services
{
    public interface ICartService
    {
        int CartCount { get; }
        IEnumerable<CartItem> Items { get; }
        void AddItem(int id, int quantity);
        void RemoveItem(int id);
        void Save();
    }

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