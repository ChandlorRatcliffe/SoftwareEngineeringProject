using CashewWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.ViewModels
{
    /// <summary>
    /// Data Dependencies for Projects Index View, Creator: Nicholas Jones
    /// </summary>
    public class ProjectsViewModel
    {
        public Projects Projects { get; set; }
        public string PageTitle { get; set; }

    }
}
