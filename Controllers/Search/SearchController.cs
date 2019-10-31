using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashewWeb.Models;
using Microsoft.AspNetCore.Mvc;
using CashewWeb.ViewModels;
using System.Web;
using System.Net;

namespace CashewWeb.Controllers
{
    public class SearchController : Controller
    {

        private readonly ISearchRepository _searchRepository;

        public SearchController(ISearchRepository searchRepository)
        {
            _searchRepository = searchRepository;
        }

        [HttpGet]
        public ViewResult Index()
        {
            var model = _searchRepository.GetAll();

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(Search search)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Results", search.Query);
            }

            return View();
        }

        public ViewResult Results(string query)
        {
            return View();
        }

    }
}
