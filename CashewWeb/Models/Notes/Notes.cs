using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.Models
{
    public class Notes
    {
        [BindProperty]
        [MaxLength(50, ErrorMessage = "Creator ID may not exceed 50 characters.")]
        public string CreatorID { get; set; }

        [BindProperty]
        [MaxLength(50, ErrorMessage = "Note ID may not exceed 50 characters.")]
        public string NoteID { get; set; }

        [BindProperty]
        [MaxLength(20, ErrorMessage = "Note Name may not exceed 20 characters.")]
        public string NoteName { get; set; }

        [BindProperty]
        [MaxLength(150, ErrorMessage = "Note Description may not exceed 150 characters.")]
        public string NoteDescription { get; set; }

        [BindProperty]
        public DateTime NoteTime { get; set; }

        [BindProperty]
        public String NoteStatus { get; set; }

    }
}
