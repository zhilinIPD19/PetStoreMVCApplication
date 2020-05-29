using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PetStoreMVCApplication.Models
{
    public class Owner
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "First name must not be more than 20 char")]
        [Display(Name = "First Name")]
        public string FirstName { get; set;}
        [Required]
        [StringLength(20, ErrorMessage = "Last name must not be more than 20 char")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [NotMapped]
        [Display(Name = "Full Name")]
        public string FullName => this.FirstName + " " + this.LastName;
        [Required]
        [StringLength(20, ErrorMessage = "Street name must not be more than 20 char")]
        public string Street { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "City name must not be more than 20 char")]
        public string City { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Occupation must not be more than 20 char")]
        public string Occupation { get; set; }
        public ICollection<Pet> Pets { get; set; }
    }
}
