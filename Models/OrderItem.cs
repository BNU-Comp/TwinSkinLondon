using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TwinSkinLondon.Models
{
    public class OrderItem
    {
        public int OrderID { get; set; }

        public int ProductID { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal Price { get; set; }

        public int Quantity { get; set; }

        // Navigation

        public Order Order { get; set; }
        public Product Product { get; set; }

    }
}
