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
    /// Controls Pipline for Tasks Related Pages, Creator: Nicholas Jones
    /// </summary>
    public class TasksController : Controller
    {
        private readonly ITasksRepository _tasksRepository;

        /// <summary>
        /// Constuctor For Tasks Controller, Gets Defined ITasksRepository From Startup.cs
        /// </summary>
        /// <param name="tasksRepository"></param>
        public TasksController(ITasksRepository tasksRepository)
        {
            _tasksRepository = tasksRepository;
        }

        /// <summary>
        /// Tasks Landing Page, Passes TasksViewModel to Page for Dependency Checking
        /// </summary>
        /// <returns>ViewResult</returns>
        public ViewResult Index()
        {
            TasksViewModel tasksViewModel = new TasksViewModel()
            {
                PageTitle = "Tasks Page"
            };
            return View(tasksViewModel);
        }

        /// <summary>
        /// Landing Page for Create Task
        /// </summary>
        /// <returns>ViewResult</returns>
        [HttpGet]
        [ActionName("CreateTask")]
        public ViewResult CreateTaskGet()
        {
            return View();
        }

        /// <summary>
        /// Create Task Post Request .. TODO
        /// </summary>
        /// <returns>ViewResult</returns>
        [HttpPost]
        [ActionName("CreateTask")]
        public RedirectToActionResult CreateTaskPost()
        {
            return RedirectToAction();
        }
    }
}
