using CashewWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.ViewModels
{
    /// <summary>
    /// Data Dependencies for Notes Index View, Creator: Nicholas Jones
    /// </summary>
    public class NotesViewModel
    {
        public Notes Notes { get; set; }
        public string PageTitle { get; set; }

    }
}
