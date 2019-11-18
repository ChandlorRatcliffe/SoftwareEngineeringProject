using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.Models
{
    public class Tasks
    {
        [BindProperty]
        [MaxLength(50, ErrorMessage = "Task ID may not exceed 50 characters.")]
        public string TaskId { get; set; }

        [BindProperty]
        [MaxLength(50, ErrorMessage = "Task Name may not exceed 50 characters.")]
        public string TaskName { get; set; }

        [BindProperty]
        public string TaskDeadline { get; set; }

        [BindProperty]
        [MaxLength(150, ErrorMessage = "Task Description may not exceed 150 characters.")]
        public string TaskDescription { get; set; }
    }
}
