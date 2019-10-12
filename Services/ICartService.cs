using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using technology_tp1.Models;

namespace technology_tp1.Services
{
    public interface ICartService
    {
        int CartCountDistinctItem { get; }
        int CartCount { get; }

        IEnumerable<CartItem> Items { get; }

        void AddItem(int id, int quantity);

        void RemoveItem(int id);

        /// <summary>
        /// Decrease the quantity of a item by x. If x > item.Quantity, the item is removed.
        /// </summary>
        /// <param name="id">Item's id</param>
        /// <param name="quantity">Quantity to remove</param>
        /// <returns>The remaining quantity</returns>
        int RemoveItem(int id, int quantity);

        int Clear();

        void Save();
    }
}