using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TwinSkinLondon.Models
{
    public class Message
    {
        public int MessageID { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)]
        public int Date { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "CustomerName cannot be longer than 50 characters.")]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
        [Required]
        [StringLength(50)]
        public string EmailAddress { get; set; }
        [Required]
        [StringLength(50)]
        public string Subject { get; set; }
        [Required]
        [StringLength(200)]
        public string MessageField { get; set; }

    }
}
