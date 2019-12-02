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
        City of London,
        Cornwall,
        County Durham,
        Cumbria,
        Derbyshire,
        Devon,
        Dorset,
        East Riding of Yorkshire,
        East Sussex,
        Essex,
        Gloucestershire,
        Greater London,
        Greater Manchester,
        Hampshire,
        Herefordshire,
        Hertfordshire,
        Humberside,
        Isle of Wight,
        Isles of Scilly,
        Kent,
        Lancashire,
        Leicestershire,
        Lincolnshire,
        Merseyside,
        Middlesex,
        Norfolk,
        North Somerset,
        North Yorkshire,
        Northamptonshire,
        Northumberland,
        Nottinghamshire,
        Oxfordshire,
        Rutland,
        Shropshire,
        Somerset,
        South Gloucestershire,
        South Yorkshire,
        Staffordshire,
        Suffolk,
        Surrey,
        Tyne & Wear,
        Warwickshire,
        West Midlands,
        West Sussex,
        West Yorkshire,
        Wiltshire,
        Worcestershire
    }
}
