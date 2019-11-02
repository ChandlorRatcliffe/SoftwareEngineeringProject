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
    /// Controls Pipline for Home Related Pages, Creator: Nicholas Jones
    /// </summary>
    public class HomeController : Controller
    {
        private readonly IHomeRepository _homeRepository;

        /// <summary>
        /// Constuctor For Home Controller, Gets Defined IHomeRepository From Startup.cs
        /// </summary>
        /// <param name="homeRepository"></param>
        public HomeController(IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;

        }

        /// <summary>
        /// Home Landing Page, Passes HomeViewModel to Page for Dependency Checking
        /// </summary>
        /// <returns>ViewResult</returns>
        public ViewResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                PageTitle = "Home Page"
            };
            return View(homeViewModel);
        }

    }
}
