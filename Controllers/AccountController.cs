using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NimbleWeb.Models;
using Microsoft.AspNetCore.Mvc;
using NimbleWeb.ViewModels;

namespace NimbleWeb.Controllers
{
    public class AccountController : Controller
    {

        private readonly IAccountRepository _accountRepository;

        public AccountController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public ViewResult Index()
        {
            var model = _accountRepository.GetAll();

            return View(model);
        }

        public ViewResult Details()
        {
            AccountViewModel accountDetailsViewModel = new AccountViewModel()
            {
                Account = _accountRepository.Get(1),
                PageTitle = "Account Details"
            };
            return View(accountDetailsViewModel);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(Account account)
        {
            Account newAccount = _accountRepository.Add(account);
            return RedirectToAction("details", new { id = newAccount.Id });
        }






    }
}
