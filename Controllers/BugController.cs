using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CashewWeb.Models;
using Microsoft.AspNetCore.Mvc;
using CashewWeb.ViewModels;

namespace CashewWeb.Controllers
{
    public class BugController : Controller
    {

        private readonly IBugRepository _bugRepository;

        public BugController(IBugRepository bugRepository)
        {
            _bugRepository = bugRepository;
        }

        public ViewResult Index()
        {
            var model = _bugRepository.GetAllBugs();

            return View(model);
        }

        public ViewResult Details()
        {
            BugDetailsViewModel bugDetailsViewModel = new BugDetailsViewModel()
            {
                Bug = _bugRepository.GetBug(1),
                PageTitle = "Bug Details"
            };
            return View(bugDetailsViewModel);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(Bug bug)
        {
            Bug newBug = _bugRepository.Add(bug);
            return RedirectToAction("details", new { id = newBug.Id});
        }



       


    }
}
