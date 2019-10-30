using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.Models
{
    public class Account
    {
        public int Id { get; set; }

        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string FirstName{ get; set; }

        [BindProperty]
        public string LastName { get; set; }

        [BindProperty]
        public string Password { get; set; }

        [BindProperty]
        public string Password1 { get; set; }

        [BindProperty]
        public string Password2 { get; set; }

        [BindProperty]
        public string Email { get; set; }

    }
}
