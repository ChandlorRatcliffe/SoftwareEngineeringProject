using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.Models
{
    public class Account
    {
        [BindProperty]
        [Required]
        [MaxLength(50, ErrorMessage = "Username may not exceed 50 characters.")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [BindProperty]
        [Required]
        [MaxLength(50, ErrorMessage = "First Name may not exceed 50 characters.")]
        [Display(Name = "First Name")]
        public string FirstName{ get; set; }

        [BindProperty]
        [Required]
        [MaxLength(150, ErrorMessage = "Last Name may not exceed 150 characters.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [BindProperty]
        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [BindProperty]
        [Required]
        [Display(Name = "Confirm")]
        public string Password2 { get; set; }

        [BindProperty]
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid Email Format")]
        public string Email { get; set; }
    }

}
