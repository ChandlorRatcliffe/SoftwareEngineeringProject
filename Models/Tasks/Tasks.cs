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
        [MaxLength(50, ErrorMessage = "TaskId may not exceed 50 characters.")]
        public string TaskId { get; set; }

        [BindProperty]
        [MaxLength(50, ErrorMessage = "TaskId may not exceed 50 characters.")]
        public DateTime TaskDeadline { get; set; }

        [BindProperty]
        [MaxLength(65335, ErrorMessage = "TaskId may not exceed 50 characters.")]
        public string TaskDescription { get; set; }
    }
}
