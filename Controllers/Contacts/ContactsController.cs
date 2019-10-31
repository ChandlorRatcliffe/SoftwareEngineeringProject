using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CashewWeb.Models;
using Microsoft.AspNetCore.Mvc;
using CashewWeb.ViewModels;

namespace CashewWeb.Controllers
{
    public class ContactsController : Controller
    {

        private readonly IContactsRepository _contactsRepository;

        public ContactsController(IContactsRepository contactsRepository)
        {
            _contactsRepository = contactsRepository;
        }

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
