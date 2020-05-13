using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArchiFolioWebApp.Models
{
    public class ProfileModel
    {
        //public int ProfileId { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You need to provide your first name.")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You need to provide your last name.")]
        public string LastName { get; set; }
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "You need to provide your Email Address.")]
        public string EmailAddress { get; set; }
        [Compare("EmailAddress", ErrorMessage = "The Email and Confirm Email must match.")]
        [Display(Name = "Confirm Email Address")]
        public string ConfirmEmail { get; set; }
        [StringLength(500, ErrorMessage = "Description must be less than 500 characters.")]
        public string Description { get; set; }
        [Display(Name = "Upload Image")]
        public string ImagePath { get; set; }
        public string Profession { get; set; }
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "The password must be at least 10 characters.")]
        [Required(ErrorMessage = "You must have a password.")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Your password and confirm password do not match.")]
        public string ConfirmPassword { get; set; }

    }
}