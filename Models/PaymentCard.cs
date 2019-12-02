using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwinSkinLondon.Models
{
    public class PaymentCard
    {
        public int CardID { get; set; }
        public string CardName { get; set; }
        public int CardNumber { get; set; }
        public int ExpiryDate { get; set; }
        public int CVV { get; set; }

    }
}
