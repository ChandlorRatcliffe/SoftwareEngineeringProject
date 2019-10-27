using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashewWeb.Models;
using Microsoft.AspNetCore.Mvc;
using CashewWeb.ViewModels;

namespace CashewWeb.Controllers
{
    public class AutomationController : Controller
    {

        private readonly IAutomationRepository _automationRepository;

        public AutomationController(IAutomationRepository automationRepository)
        {
            _automationRepository = automationRepository;
        }

        public ViewResult Index()
        {
            var model = _automationRepository.GetAll();

            return View(model);
        }

        public ViewResult Details()
        {
            AutomationViewModel automationDetailsViewModel = new AutomationViewModel()
            {
                Automation = _automationRepository.Get(1),
                PageTitle = "Automation Details"
            };
            return View(automationDetailsViewModel);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(Automation automation)
        {
            Automation newAutomation = _automationRepository.Add(automation);
            return RedirectToAction("details", new { id = newAutomation.Id });
        }






    }
}
