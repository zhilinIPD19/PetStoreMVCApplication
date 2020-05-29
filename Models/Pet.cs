using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetStoreMVCApplication.Models
{
    public enum Breed
    {
        Dog, Cat, Fish, Hamster, GuineaPig
    }
    public class Pet
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Name must not be more than 10 char")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Date Of Birthday")]
        public DateTime DOB { get; set; }
        [Required]
        public Breed Breed { get; set; }
        [Required]
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}
