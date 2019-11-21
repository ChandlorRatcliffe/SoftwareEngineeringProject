using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashewWeb.Models;
using Microsoft.AspNetCore.Mvc;
using CashewWeb.ViewModels;

namespace CashewWeb.Controllers
{
    /// <summary>
    /// Controls Pipline for Progress Related Pages, Creator: Nicholas Jones
    /// </summary>
    public class ProgressController : Controller
    {
        private readonly IProgressRepository _progressRepository;

        /// <summary>
        /// Constuctor For Progress Controller, Gets Defined IProgressRepository From Startup.cs
        /// </summary>
        /// <param name="progressRepository"></param>
        public ProgressController(IProgressRepository progressRepository)
        {
            _progressRepository = progressRepository;

        }

        /// <summary>
        /// Progress Landing Page, Passes ProgressViewModel to Page for Dependency Checking
        /// </summary>
        /// <returns>ViewResult</returns>
        public ViewResult Index()
        {
            ProgressViewModel progressViewModel = new ProgressViewModel()
            {
                PageTitle = "Progress Page"
            };
            return View(progressViewModel);
        }
    }
}
