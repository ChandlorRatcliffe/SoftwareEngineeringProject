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
        public string TaskID { get; set; }

        [BindProperty]
        [MaxLength(50, ErrorMessage = "Task Name may not exceed 50 characters.")]
        public string TaskName { get; set; }

        [BindProperty]
        [MaxLength(50, ErrorMessage = "Task Deadine may not exceed 50 characters.")]
        public DateTime TaskDeadline { get; set; }

        [BindProperty]
        [MaxLength(500, ErrorMessage = "TaskId may not exceed 500 characters.")]
        public string TaskDescription { get; set; }
    }
}
