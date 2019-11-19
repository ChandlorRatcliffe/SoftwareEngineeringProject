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
    /// Controls Pipline for Chat Related Pages, Creator: Nicholas Jones
    /// </summary>
    public class ChatController : Controller
    {
        private readonly IChatRepository _chatRepository;

        /// <summary>
        /// Constuctor For Chat Controller, Gets Defined IChatRepository From Startup.cs
        /// </summary>
        /// <param name="chatRepository"></param>
        public ChatController(IChatRepository chatRepository)
        {
            _chatRepository = chatRepository;
        }

        /// <summary>
        /// Chat Landing Page, Passes ChatViewModel to Page for Dependency Checking
        /// </summary>
        /// <returns>ViewResult</returns>
        public ViewResult Index()
        {
            ChatViewModel chatViewModel = new ChatViewModel()
            {
                PageTitle = "Progress Page"
            };
            return View(chatViewModel);
        }

    }
}
