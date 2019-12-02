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
        [Required]
        [StringLength(50, ErrorMessage = "CustomerName cannot be longer than 50 characters.")]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public int Date { get; set; }
        public int ProductID { get; set; }
        public int StarRating { get; set; }
        [Required]
        [StringLength(300)]
        public string ReviewField { get; set; }

    }
}
