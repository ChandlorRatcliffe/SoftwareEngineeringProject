using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashewWeb.Models;
using Microsoft.AspNetCore.Mvc;
using CashewWeb.ViewModels;

namespace CashewWeb.Controllers
{
    public class ReportsController : Controller
    {

        private readonly IReportsRepository _reportsRepository;

        public ReportsController(IReportsRepository reportsRepository)
        {
            _reportsRepository = reportsRepository;
        }

        public ViewResult Index()
        {
            var model = _reportsRepository.GetAll();

            return View(model);
        }

        public ViewResult Details()
        {
            ReportsViewModel reportsDetailsViewModel = new ReportsViewModel()
            {
                Reports = _reportsRepository.Get(1),
                PageTitle = "Reports Details"
            };
            return View(reportsDetailsViewModel);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(Reports reports)
        {
            Reports newReports = _reportsRepository.Add(reports);
            return RedirectToAction("details", new { id = newReports.Id });
        }






    }
}
