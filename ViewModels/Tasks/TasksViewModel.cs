using CashewWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.ViewModels
{
    /// <summary>
    /// Data Dependencies for Tasks Index View, Creator: Nicholas Jones
    /// </summary>
    public class TasksViewModel
    {
        public Tasks Tasks { get; set; }
        public string PageTitle { get; set; }

    }
}
