using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace technology_tp1.Models
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        public DateTime DeliveredAt { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerAdress { get; set; }
        [Phone]
        [Required]
        public string CustomerPhoneNumber { get; set; }
        public IEnumerable<OrdersItems> OrdersItems { get; set; }
        [NotMapped]
        public IEnumerable<CartItem> Items => OrdersItems.Select(oi => new CartItem(oi.MenuItem, oi.Quantity));
    }

    public class OrdersItems
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int MenuItemId { get; set; }
        public MenuItem MenuItem { get; set; }
        public int Quantity { get; set; }
    }
}
