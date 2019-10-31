using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashewWeb.Models;
using Microsoft.AspNetCore.Mvc;
using CashewWeb.ViewModels;

namespace CashewWeb.Controllers
{
    public class NotesController : Controller
    {
        private readonly INotesRepository _notesRepository;

        public NotesController(INotesRepository notesRepository)
        {
            _notesRepository = notesRepository;
        }

        public ViewResult Index()
        {
            NotesViewModel notesViewModel = new NotesViewModel()
            {
                PageTitle = "Progress Page"
            };
            return View(notesViewModel);
        }


    }
}
