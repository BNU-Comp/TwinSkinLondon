using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TwinSkinLondon.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        public int CustomerID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public int ProductID { get; set; }

        [Range(1,5)]
        public int StarRating { get; set; }

        [Required]
        [StringLength(500), DataType(DataType.MultilineText)]
        public string ReviewField { get; set; }

        //

        public virtual Product Product { get; set; }

        public virtual Customer Customer { get; set; }

    }
}
