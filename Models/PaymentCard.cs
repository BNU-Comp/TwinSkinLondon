using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TwinSkinLondon.Models
{
    public class PaymentCard
    {
        public int CardID { get; set; }

        [Required, StringLength(20)]
        public string CardName { get; set; }

        [Required, StringLength(20)]
        public string CardNumber { get; set; }

        [Required, Range(1,12)]
        public int ExpiryMonth { get; set; }

        [Required, Range(2019, 2030)]
        public int ExpiryYear { get; set; }

        [Required, Range(0,999)]
        public int CVV { get; set; }

        //public int CustomerID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        //public virtual Customer Customer { get; set; }

    }
}
