using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.Models
{
    /// <summary>
    /// User Accounts Creator: Nicholas Jones
    /// </summary>
    public class Accounts
    {
        [BindProperty]
        [Required]
        [MaxLength(50, ErrorMessage = "Username may not exceed 50 characters.")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [BindProperty]
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid Email Format")]
        [MaxLength(150, ErrorMessage = "Email may not exceed 150 characters.")]
        public string Email { get; set; }

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
        [MaxLength(150, ErrorMessage = "Password may not exceed 150 characters.")]
        [MinLength(8, ErrorMessage = "Password may not be less than 8 characters.")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [MaxLength(250, ErrorMessage = "Role may not exceed 250 characters.")]
        [BindProperty]
        public string Role { get; set; }

        [MaxLength(6000, ErrorMessage = "Skills may not exceed 6000 characters.")]
        [BindProperty]
        public string Skills { get; set; }

        [MaxLength(1000, ErrorMessage = "Theme may not exceed 1000 characters.")]
        [BindProperty]
        public string Theme { get; set; }

        //TODO Add this after Uploads are added
        [MaxLength(5000, ErrorMessage = "PicturePath may not exceed 5000 characters.")]
        [BindProperty]
        public string PicturePath { get; set; }



        //Unbound to Database Data
        [NotMapped]
        [Required]
        [Display(Name = "Confirm")]
        public string Password2 { get; set; }


    }

}
