using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace technology_tp1.Models
{
    public class DeliveryMan
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public bool IsEmployed { get; set; }

        public bool IsDeactivated { get; set; }

        public DeliveryMan(){}

        public DeliveryMan(int id, string name, string phone, bool isEmployed)
        {
            Id = id;
            Name = name;
            Phone = phone;
            IsEmployed = isEmployed;
        }
    }
}
