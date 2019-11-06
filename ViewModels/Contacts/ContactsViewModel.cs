using CashewWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.ViewModels
{
    /// <summary>
    /// Data Dependencies for Contacts Index View, Creator: Nicholas Jones
    /// </summary>
    public class ContactsViewModel
    {
        public Contacts Contacts { get; set; }
        public string PageTitle { get; set; }

    }
}
