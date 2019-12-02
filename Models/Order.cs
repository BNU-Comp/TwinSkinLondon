using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TwinSkinLondon.Models
{
    public class Order
    {

        public int OrderID { get; set; }
        public decimal VAT { get; set; }
        public decimal DeliveryCharge { get; set; }
        public decimal Total { get; set; }

    }
}
