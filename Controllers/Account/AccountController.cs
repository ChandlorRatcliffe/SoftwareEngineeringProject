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
    public class AccountController : Controller
    {

        private readonly IAccountRepository _accountRepository;

        public AccountController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        [HttpGet]
        [ActionName("Index")]
        public ViewResult IndexGet()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Index")]
        public IActionResult IndexPost(Account account)
        {
            Debug.WriteLine(account.Username);
            Debug.WriteLine(account.Password);
            //Debug.WriteLine(Request["Username"]);
            Debug.WriteLine("TESFDDDDDDDDDDDDDDDD");


            Account newAccount = _accountRepository.Add(account);
            return RedirectToAction("Details", new { username = newAccount.Username });
        }

        [HttpGet]
        [ActionName("Details")]
        public ViewResult DetailsGet(Account account)
        {
            AccountViewModel accountDetailsViewModel = new AccountViewModel()
            {
                Account = _accountRepository.Get(account.Username),
                PageTitle = "Account Details"
            };
            return View(accountDetailsViewModel);
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
        public IActionResult CreatePost(Account account)
        {
            if (ModelState.IsValid)
            {
                Account newAccount = _accountRepository.Add(account);
                return RedirectToAction("Details", new { username = newAccount.Username });
            }
            else
                return View();
        }


    }
}
