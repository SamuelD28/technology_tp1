using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace technology_tp1.Models
{
    public class Order
    {
        public int Id { get; set; }

        public ICollection<OrderMenuItem> OrderMenuItems { get; set; }

        public int ClientName { get; set; }

        public string ClientAdress { get; set; }

        public string ClientPhoneNumber { get; set; }

        public int DeliveryManId { get; set; }

        public DeliveryMan DeliveryMan { get; set; }

        public bool Sent { get; set; }
    }
}
