using CashewWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.ViewModels
{
    /// <summary>
    /// Data Dependencies for Accounts Index View, Creator: Nicholas Jones
    /// </summary>
    public class AccountsViewModel
    {
        public Accounts Accounts { get; set; }
        public string PageTitle { get; set; }

    }
}
