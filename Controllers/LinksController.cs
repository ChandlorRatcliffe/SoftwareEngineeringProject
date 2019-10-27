using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashewWeb.Models;
using Microsoft.AspNetCore.Mvc;
using CashewWeb.ViewModels;

namespace CashewWeb.Controllers
{
    public class LinksController : Controller
    {

        private readonly ILinksRepository _LlnksRepository;

        public LinksController(ILinksRepository LlnksRepository)
        {
            _LlnksRepository = LlnksRepository;
        }

        public ViewResult Index()
        {
            var model = _LlnksRepository.GetAll();

            return View(model);
        }

        public ViewResult Details()
        {
            LinksViewModel LlnksDetailsViewModel = new LinksViewModel()
            {
                Links = _LlnksRepository.Get(1),
                PageTitle = "Links Details"
            };
            return View(LlnksDetailsViewModel);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(Links Llnks)
        {
            Links newLinks = _LlnksRepository.Add(Llnks);
            return RedirectToAction("details", new { id = newLinks.Id });
        }






    }
}
