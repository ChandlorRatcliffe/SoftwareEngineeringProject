using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashewWeb.Models;
using Microsoft.AspNetCore.Mvc;
using CashewWeb.ViewModels;

namespace CashewWeb.Controllers
{
    public class ProgressController : Controller
    {
        private readonly IProgressRepository _progressRepository;

        public ProgressController(IProgressRepository progressRepository)
        {
            _progressRepository = progressRepository;

        }

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
