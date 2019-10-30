using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashewWeb.Models;
using Microsoft.AspNetCore.Mvc;
using CashewWeb.ViewModels;

namespace CashewWeb.Controllers
{
    public class ChatController : Controller
    {
        private readonly IChatRepository _chatRepository;

        public ChatController(IChatRepository chatRepository)
        {
            _chatRepository = chatRepository;
        }

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
