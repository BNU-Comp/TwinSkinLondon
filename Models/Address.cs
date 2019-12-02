using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TwinSkinLondon.Models
{
    public class Address
    {

        public int AddressID { get; set; }
        public string AddressLine1 { get; set; }
        public string Street { get; set; }
        public string County { get; set; }
        public string Town { get; set; }
        public string Postcode { get; set; }

    }
}
