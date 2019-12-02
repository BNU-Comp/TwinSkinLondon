using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TwinSkinLondon.Models
{
    public class Address
    {
        //Tom B
        public int AddressID { get; set; }

        public string HouseNumber { get; set; }

        public string Street { get; set; }

        public Counties County { get; set; }

        public string Town { get; set; }

        public string Postcode { get; set; }

        //

    }

    public enum Counties
    {
        Bucks,
        Herts,
        Beds
    }
}
