using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashewWeb.Models;
using Microsoft.AspNetCore.Mvc;
using CashewWeb.ViewModels;

namespace CashewWeb.Controllers
{
    public class TasksController : Controller
    {
        private readonly ITasksRepository _tasksRepository;

        public TasksController(ITasksRepository tasksRepository)
        {
            _tasksRepository = tasksRepository;

        }

        public ViewResult Index()
        {
            TasksViewModel tasksViewModel = new TasksViewModel()
            {
                PageTitle = "Tasks Page"
            };
            return View(tasksViewModel);
        }
    }
}
