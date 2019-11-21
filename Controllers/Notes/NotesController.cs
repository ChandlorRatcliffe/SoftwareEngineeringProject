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
    /// Controls Pipline for Notes Related Pages, Creator: Nicholas Jones
    /// </summary>
    public class NotesController : Controller
    {
        private readonly INotesRepository _notesRepository;

        /// <summary>
        /// Constuctor For Notes Controller, Gets Defined INotesRepository From Startup.cs
        /// </summary>
        /// <param name="notesRepository"></param>
        public NotesController(INotesRepository notesRepository)
        {
            _notesRepository = notesRepository;
        }

        /// <summary>
        /// Notes Landing Page, Passes NotesViewModel to Page for Dependency Checking
        /// </summary>
        /// <returns>ViewResult</returns>
        public ViewResult Index()
        {
            NotesViewModel notesViewModel = new NotesViewModel()
            {
                PageTitle = "Progress Page"
            };
            return View(notesViewModel);
        }

        [HttpGet]
        [ActionName("CreateNote")]
        public ViewResult CreateNoteGet()
        {
            return View();
        }

        [HttpPost]
        [ActionName("CreateNote")]
        public ViewResult CreateNotePost()
        {
            return View();
        }
    }
}
