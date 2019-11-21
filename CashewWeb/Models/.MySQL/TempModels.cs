using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;



namespace CashewWeb.Models
{
    /// <summary>
    /// Temporary Model Binings: Nicholas Jones
    /// </summary>
    /// 

    public class OrganizationAbilities
    {
        [BindProperty]
        [Required]
        [MaxLength(100, ErrorMessage = " may not exceed 50 characters.")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [BindProperty]
        [Required]
        [MaxLength(150, ErrorMessage = "Email may not exceed 150 characters.")]
        public string Email { get; set; }

        [BindProperty]
        [Required]
        [MaxLength(50, ErrorMessage = "Name may not exceed 150 characters.")]
        public string Name { get; set; }

        [BindProperty]
        public int RemoveUser { get; set; }

        [BindProperty]
        public int InviteUser { get; set; }

        [BindProperty]
        public int PermissionsEditing { get; set; }
    }

    public class Organizations
    {
        [BindProperty]
        [MaxLength(50, ErrorMessage = "Name may not exceed 150 characters.")]
        public string Name { get; set; }

        [BindProperty]
        [MaxLength(50, ErrorMessage = "Name may not exceed 150 characters.")]
        public string Licenses { get; set; }

        [BindProperty]
        public int Activation { get; set; }

        [BindProperty]
        public DateTime Expiration { get; set; }
    }

    public class Parents
    {
        [BindProperty]
        public string ParentId { get; set; }

        [BindProperty]
        public string ChildId { get; set; }
    }

    public class ProjectAbilities
    {
        [BindProperty]
        [Required]
        [MaxLength(100, ErrorMessage = " may not exceed 50 characters.")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [BindProperty]
        [Required]
        [MaxLength(150, ErrorMessage = "Email may not exceed 150 characters.")]
        public string Email { get; set; }

        [BindProperty]
        [MaxLength(50, ErrorMessage = "ProjectId may not exceed 50 characters.")]
        public string ProjectId { get; set; }

        [BindProperty]
        public int AssignmentEditing { get; set; }

        [BindProperty]
        public int ProjectEditing { get; set; }

        [BindProperty]
        public int CreateProject { get; set; }
    }

    public class TaskAbilities
    {
        [BindProperty]
        [Required]
        [MaxLength(100, ErrorMessage = " may not exceed 50 characters.")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [BindProperty]
        [Required]
        [MaxLength(150, ErrorMessage = "Email may not exceed 150 characters.")]
        public string Email { get; set; }

        [BindProperty]
        [MaxLength(50, ErrorMessage = "TaskId may not exceed 50 characters.")]
        public string TaskId { get; set; }

        [BindProperty]
        public int AssignmentEditing { get; set; }
    }

}
