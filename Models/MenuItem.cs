using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace technology_tp1.Models
{
    public class MenuItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string  Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int ImageId { get; set; }

        public ItemImage Image { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
