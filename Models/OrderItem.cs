using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TwinSkinLondon.Models
{
    public class OrderItem
    {
        // This primary key was missing
        public int OrderItemID { get; set; }

        public int OrderID { get; set; }

        public int ProductID { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal Price { get; set; }

        public int Quantity { get; set; }

        // Navigation

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }

    }
}
