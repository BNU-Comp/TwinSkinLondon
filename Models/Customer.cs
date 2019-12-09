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
        [StringLength(50), DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [StringLength(20), DataType(DataType.PhoneNumber)]
        public string ContactNumber { get; set; }

        // Foreign Keys
        
        public Nullable<int> PaymentCardID { get; set; }

        public Nullable<int> AddressID { get; set; }

        // Navigation Properties

        public virtual PaymentCard PaymentCard { get; set; }

        public virtual Address Address { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        public virtual ICollection<Message> Messages { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

    }
}
