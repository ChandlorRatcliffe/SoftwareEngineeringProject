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
    /// <summary>
    /// Controls Pipline for Account Related Pages, Creator: Nicholas Jones
    /// </summary>
    public class AccountsController : Controller
    {
        private readonly IAccountsRepository _AccountsRepository;

        /// <summary>
        /// Constuctor For Chat Controller, Gets Defined IChatRepository From Startup.cs
        /// </summary>
        /// <param name="AccountsRepository"></param>
        public AccountsController(IAccountsRepository AccountsRepository)
        {
            _AccountsRepository = AccountsRepository;
        }

        /// <summary>
        /// Landing Page For Account
        /// </summary>
        /// <param name="error">Add Error Message if Account Issue Occurs</param>
        /// <returns>ViewResult</returns>
        [HttpGet]
        [ActionName("Index")]
        public ViewResult IndexGet(string error)
        {
            if (error != null)
                return View();
            else
                return View(error);
        }

        /// <summary>
        /// Post Request from Landing Page To Request Authentication ... Not Fully Implemented Yet
        /// </summary>
        /// <param name="Accounts">Account to Authenticate</param>
        /// <returns>IActionResult</returns>
        [HttpPost]
        [ActionName("Index")]
        public IActionResult IndexPost(Accounts Accounts)
        {
            return RedirectToAction("Error");
        }

        /// <summary>
        /// Gets the details of the account and displays them on the screen... Debugging Only
        /// </summary>
        /// <param name="Accounts">Account to get Details</param>
        /// <returns>ViewResult</returns>
        [HttpGet]
        [ActionName("Details")]
        public ViewResult DetailsGet(Accounts Accounts)
        {
            AccountsViewModel AccountsDetailsViewModel = new AccountsViewModel()
            {
                Accounts = _AccountsRepository.Get(Accounts.Username, Accounts.Email),
                PageTitle = "Accounts Details"
            };
            return View(AccountsDetailsViewModel);
        }

        /// <summary>
        /// Landing Page for Password Recovery .. TODO
        /// </summary>
        /// <returns>ViewResult</returns>
        [HttpGet]
        [ActionName("RecoveryPassword")]
        public ViewResult RecoveryPasswordGet()
        {
            return View();
        }

        /// <summary>
        /// Password Recovery Post Request .. TODO
        /// </summary>
        /// <returns>ViewResult</returns>
        [HttpPost]
        [ActionName("RecoveryPassword")]
        public RedirectToActionResult RecoveryPasswordPost()
        {
            return RedirectToAction("Error");
        }

        /// <summary>
        /// Landing Page for Username Recovery .. TODO
        /// </summary>
        /// <returns>ViewResult</returns>
        [HttpGet]
        [ActionName("RecoveryUsername")]
        public ViewResult RecoveryUsernameGet()
        {
            return View();
        }

        /// <summary>
        /// Username Recovery Post Request .. TODO
        /// </summary>
        /// <returns>ViewResult</returns>
        [HttpPost]
        [ActionName("RecoveryUsername")]
        public RedirectToActionResult RecoveryUsernamePost()
        {
            return RedirectToAction("Error");

        }

        /// <summary>
        /// Create Account Landing Page
        /// </summary>
        /// <returns>ViewResult</returns>
        [HttpGet]
        [ActionName("Create")]
        public ViewResult CreateGet()
        {
            return View();
        }

        /// <summary>
        /// Account Creation Post Request .. Adds to Database .. If Unsuccessful redirect to Index with Error
        /// </summary>
        /// <param name="Accounts">Account to add</param>
        /// <returns>IActionResult</returns>
        [HttpPost]
        [ActionName("Create")]
        public IActionResult CreatePost(Accounts Accounts)
        {
            if (ModelState.IsValid)
            {
                Accounts newAccounts = _AccountsRepository.Add(Accounts);
                if (newAccounts != null)
                {
                    return RedirectToAction("Details", new { username = newAccounts.Username, email = newAccounts.Email });
                }
                else
                {
                    return RedirectToAction("Index", "Accounts", "Error has occured");
                }
            }
            else
                return View();
        }

        public ViewResult Error()
        {
            return View();
        }





    }
}
