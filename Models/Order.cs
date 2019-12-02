using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace TwinSkinLondon.Models
{
    public class Order
    {
        public int OrderID { get; set; }

        public DateTime DateOrdered { get; set; }

        public DateTime DateDelivered { get; set; }

        public Status Status { get; set; }

        [DataType(DataType.Currency)] 
        public decimal VAT { get; set; }

        [DataType(DataType.Currency)] // format string
        public decimal DeliveryCharge { get; set; }

        public int CustomerID { get; set; }
        // Navigation

        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
 

    }

    public enum Status
    {
        recieved,
        packaged,
        delivered
    }
}
