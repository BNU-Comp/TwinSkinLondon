using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TwinSkinLondon.Models
{
    /// <summary>
    /// Comment
    /// </summary>
    public class Customer
    {
        public int CustomerID { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "FirstName cannot be longer than 50 characters.")]
        [Display(Name="First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "LastName cannot be longer than 50 characters.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        public string EmailAddress { get; set; }
        public string ContactNumber { get; set; }
        [Required]
        private string Password { get; set; }

    }
}
