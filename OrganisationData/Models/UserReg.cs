using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace OrganisationData.Models
{
    public class UserReg
    {
        
        [Required(ErrorMessage ="Please enter your first name")]
        [Display(Name ="First Name")]
        public string Fname { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        [Display(Name = "Last Name")]
        public string Lname { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [Display(Name = "Email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password")]
        [DataType(DataType.Password)]
        [Display(Name = " CPassword")]
        [Compare("Password")]
        public string CPassword { get; set; }

    }
}
