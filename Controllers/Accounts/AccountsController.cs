using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashewWeb.Models;
using Microsoft.AspNetCore.Mvc;
using CashewWeb.ViewModels;
using System.Diagnostics;

namespace CashewWeb.Controllers
{
    public class AccountsController : Controller
    {

        private readonly IAccountsRepository _AccountsRepository;

        public AccountsController(IAccountsRepository AccountsRepository)
        {
            _AccountsRepository = AccountsRepository;
        }

        [HttpGet]
        [ActionName("Index")]
        public ViewResult IndexGet(string error)
        {
            if (error != null)
                return View();
            else
                return View(error);
        }

        [HttpPost]
        [ActionName("Index")]
        public IActionResult IndexPost(Accounts Accounts)
        {
            Debug.WriteLine(Accounts.Username);
            Debug.WriteLine(Accounts.Password);
            //Debug.WriteLine(Request["Username"]);
            Debug.WriteLine("TESFDDDDDDDDDDDDDDDD");


            Accounts newAccounts = _AccountsRepository.Add(Accounts);
            return RedirectToAction("Details", new { username = newAccounts.Username });
        }

        [HttpGet]
        [ActionName("Details")]
        public ViewResult DetailsGet(Accounts Accounts)
        {
            AccountsViewModel AccountsDetailsViewModel = new AccountsViewModel()
            {
                Accounts = _AccountsRepository.Get(Accounts.Username),
                PageTitle = "Accounts Details"
            };
            return View(AccountsDetailsViewModel);
        }

        [HttpGet]
        [ActionName("Recovery")]
        public ViewResult RecoveryGet()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Recovery")]
        public ViewResult RecoveryPost()
        {
            return View();
        }

        [HttpGet]
        [ActionName("Create")]
        public ViewResult CreateGet()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public IActionResult CreatePost(Accounts Accounts)
        {
            if (ModelState.IsValid)
            {
                Accounts newAccounts = _AccountsRepository.Add(Accounts);
                if (newAccounts != null)
                {
                    return RedirectToAction("Details", new { username = newAccounts.Username });
                }
                else
                {
                    return RedirectToAction("Index", "Accounts", "Error has occured");
                }
            }
            else
                return View();
        }


    }
}
