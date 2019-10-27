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
            HomeViewModel homeDetailsViewModel = new HomeViewModel()
            {
                Home = _homeRepository.GetHome(1),
                PageTitle = "Home"
            };

            return View(homeDetailsViewModel);
        }

        

    }
}

/*
            public JsonResult Details()
        {
            Bug bug = _bugRepository.GetBug(1);
            return Json(bug);
        }
        */
/* FOR REST API
 public ObjectResult Details()
{
    Bug bug = _bugRepository.GetBug(1);
    return new ObjectResult(bug);
} 

*/
