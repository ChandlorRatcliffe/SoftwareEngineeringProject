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
    /// <summary>
    /// Controls Pipline for Search Related Pages, Creator: Nicholas Jones
    /// </summary>
    public class SearchController : Controller
    {

        private readonly ISearchRepository _searchRepository;

        /// <summary>
        /// Constuctor For Search Controller, Gets Defined ISearchRepository From Startup.cs
        /// </summary>
        /// <param name="searchRepository"></param>
        public SearchController(ISearchRepository searchRepository)
        {
            _searchRepository = searchRepository;
        }

        /// <summary>
        /// Search Landing Page, Gets all Search Results... TODO
        /// </summary>
        /// /// <param name="query">Query</param>
        /// <returns>ViewResult</returns>
        [HttpGet]
        public ViewResult Index(string query)
        {
            return View();
        }

        /// <summary>
        /// Search Post Request, This is where the search will need to perform query then be redirected to Landing Page
        /// </summary>
        /// <param name="search">Search Model</param>
        /// <returns>IActionResult</returns>
        [HttpPost]
        public IActionResult Index(Search search)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", search.Query);
            }
            return View();
        }

    }
}
