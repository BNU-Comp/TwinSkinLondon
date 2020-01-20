using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TwinSkinLondon.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(1000), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public Categories  Category { get; set; }

        [StringLength(100), DataType(DataType.ImageUrl)]
        public string ImageURL { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal ProductPrice { get; set; }

        [StringLength(100), DataType(DataType.Url)]
        public string VideoURL { get; set; }

        [Range(1, 10)]
        public int Quantity { get; set; }

        // Navigation

        public ICollection<OrderItem> OrderItems { get; set; }
    }

    public enum Categories
    {
        Facial,
        Body,
        Hair,
        Accessories
    }
}
