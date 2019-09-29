using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace technology_tp1.Models
{
    public class MenuItem
    {
        public int Id { get; set; }

        public string  Nom { get; set; }

        public double Prix { get; set; }

        public int ImageId { get; set; }

        public ItemImage Image { get; set; }
    }
}
