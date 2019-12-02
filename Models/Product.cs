using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TwinSkinLondon.Models
{
    public class Product
    {
        private int ProductID { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(150)]
        public string Description { get; set; }
        [Required]
        [StringLength(50)]
        public string Category { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public string Video { get; set; }
        public int Quantity { get; set; }


    }
}
