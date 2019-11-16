using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.Models
{
    public class Projects
    {
        [BindProperty]
        [MaxLength(50, ErrorMessage = "Project ID may not exceed 50 characters.")]
        public string ProjectID { get; set; }

        [BindProperty]
        [MaxLength(50, ErrorMessage = "Project Name may not exceed 50 characters.")]
        public string ProjectName { get; set; }

        [BindProperty]
        [MaxLength(150, ErrorMessage = "Project Description may not exceed 150 characters.")]
        public string ProjectDescription { get; set; }

        [BindProperty]
        public string ProjectDeadline { get; set; }
    }
}
