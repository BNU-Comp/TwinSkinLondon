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
        Bedfordshire,
        Berkshire,
        Bristol,
        Buckinghamshire,
        Cambridgeshire,
        Cheshire,
        CityofLondon,
        Cornwall,
        CountyDurham,
        Cumbria,
        Derbyshire,
        Devon,
        Dorset,
        EastRidingofYorkshire,
        EastSussex,
        Essex,
        Gloucestershire,
        GreaterLondon,
        GreaterManchester,
        Hampshire,
        Herefordshire,
        Hertfordshire,
        Humberside,
        IsleofWight,
        IslesofScilly,
        Kent,
        Lancashire,
        Leicestershire,
        Lincolnshire,
        Merseyside,
        Middlesex,
        Norfolk,
        NorthSomerset,
        NorthYorkshire,
        Northamptonshire,
        Northumberland,
        Nottinghamshire,
        Oxfordshire,
        Rutland,
        Shropshire,
        Somerset,
        SouthGloucestershire,
        SouthYorkshire,
        Staffordshire,
        Suffolk,
        Surrey,
        Warwickshire,
        WestMidlands,
        WestSussex,
        WestYorkshire,
        Wiltshire,
        Worcestershire,
    }
}
