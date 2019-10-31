using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CashewWeb.Models;
using Microsoft.AspNetCore.Mvc;
using CashewWeb.ViewModels;

namespace CashewWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeRepository _homeRepository;

        public HomeController(IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;

        }

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
