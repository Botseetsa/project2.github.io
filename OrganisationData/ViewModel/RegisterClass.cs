using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrganisationData.ViewModel
{
    public class RegisterClass
    {
       [Required]
        [Display(Name = "Enter your first name")]
        public string Fname { get; set; }

        [Required]
        [Display(Name = "Enter your last name")]
        public string Lname { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Your password does not match")]
        public string CPassword { get; set; }
    }
}

