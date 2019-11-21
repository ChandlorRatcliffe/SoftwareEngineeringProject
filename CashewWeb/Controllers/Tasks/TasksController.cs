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
        [HttpGet]
        [ActionName("Index")]
        public ViewResult Index()
        {
            TasksViewModel taskViewModel = new TasksViewModel()
            {
                PageTitle = "Tasks Page"
            };
            return View(taskViewModel);
        }

        /// <summary>
        /// Post Request from Landing Page To Request Authentication ... Not Fully Implemented Yet
        /// </summary>
        /// <param name="Project">Project to Authenticate</param>
        /// <returns>IActionResult</returns>
        [HttpPost]
        [ActionName("Index")]
        public IActionResult IndexPost(Accounts Accounts)
        {
            return RedirectToAction("Error");
        }

        /// <summary>
        /// Landing Page for Task Page .. TODO
        /// </summary>
        /// <returns>ViewResult</returns>
        [HttpGet]
        [ActionName("TaskPage")]
        public ViewResult TaskPageGet()
        {
            return View();
        }

        /// <summary>
        /// Task Page Post Request .. TODO
        /// </summary>
        /// <returns>ViewResult</returns>
        [HttpPost]
        [ActionName("TaskPage")]
        public RedirectToActionResult TaskPagePost()
        {
            return RedirectToAction("Error");
        }

        public ViewResult Error()
        {
            return View();
        }
    }
}
