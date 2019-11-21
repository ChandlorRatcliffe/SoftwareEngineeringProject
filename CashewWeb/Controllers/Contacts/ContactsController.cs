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
    /// Controls Pipline for Contacts Related Pages, Creator: Nicholas Jones
    /// </summary>
    public class ContactsController : Controller
    {

        private readonly IContactsRepository _contactsRepository;

        /// <summary>
        /// Constuctor For Contacts Controller, Gets Defined IContactsRepository From Startup.cs
        /// </summary>
        /// <param name="contactsRepository"></param>
        public ContactsController(IContactsRepository contactsRepository)
        {
            _contactsRepository = contactsRepository;
        }

        /// <summary>
        /// Contacts Landing Page, Passes ContactsViewModel to Page for Dependency Checking
        /// </summary>
        /// <returns>ViewResult</returns>
        public ViewResult Index()
        {
            ContactsViewModel contactsViewModel = new ContactsViewModel()
            {
                PageTitle = "Progress Page"
            };
            return View(contactsViewModel);
        }

    }
}
