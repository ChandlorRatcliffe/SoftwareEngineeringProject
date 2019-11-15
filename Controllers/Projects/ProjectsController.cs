using System;
using System.Collections.Generic;
using System.Linq;
using CashewWeb.Models;
using Microsoft.AspNetCore.Mvc;
using CashewWeb.ViewModels;

namespace CashewWeb.Controllers
{
    /// <summary>
    /// Controls Pipline for Tasks Related Pages, Creator: Nicholas Jones
    /// </summary>
    public class ProjectsController : Controller
    {
        private readonly IProjectsRepository _projectsRepository;

        /// <summary>
        /// Constuctor For Projects Controller, Gets Defined IProjectsRepository From Startup.cs
        /// </summary>
        /// <param name="projectsRepository"></param>
        public ProjectsController(IProjectsRepository projectsRepository)
        {
            _projectsRepository = projectsRepository;
        }

        /// <summary>
        /// Tasks Landing Page, Passes TasksViewModel to Page for Dependency Checking
        /// </summary>
        /// <returns>ViewResult</returns>
        [HttpGet]
        [ActionName("Index")]
        public ViewResult Index()
        {
            ProjectsViewModel projectsViewModel = new ProjectsViewModel()
            {
                PageTitle = "Projects Page"
            };
            return View(projectsViewModel);
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
        /// Landing Page for Permission Management .. TODO
        /// </summary>
        /// <returns>ViewResult</returns>
        [HttpGet]
        [ActionName("PermissionManagement")]
        public ViewResult PermissionManagementGet()
        {
            return View();
        }

        /// <summary>
        /// Permission Management Post Request .. TODO
        /// </summary>
        /// <returns>ViewResult</returns>
        [HttpPost]
        [ActionName("PermissionManagement")]
        public RedirectToActionResult PermissionManagementPost()
        {
            return RedirectToAction("Error");
        }

        /// <summary>
        /// Landing Page for Team Management .. TODO
        /// </summary>
        /// <returns>ViewResult</returns>
        [HttpGet]
        [ActionName("TeamManagement")]
        public ViewResult TeamManagementGet()
        {
            return View();
        }

        /// <summary>
        /// Team Management Post Request .. TODO
        /// </summary>
        /// <returns>ViewResult</returns>
        [HttpPost]
        [ActionName("TeamManagement")]
        public RedirectToActionResult TeamManagementPost()
        {
            return RedirectToAction("Error");
        }

        /// <summary>
        /// Landing Page for Permission Management .. TODO
        /// </summary>
        /// <returns>ViewResult</returns>
        [HttpGet]
        [ActionName("ProjectPage")]
        public ViewResult ProjectPageGet()
        {
            return View();
        }

        /// <summary>
        /// Permission Management Post Request .. TODO
        /// </summary>
        /// <returns>ViewResult</returns>
        [HttpPost]
        [ActionName("ProjectPage")]
        public RedirectToActionResult ProjectPagePost()
        {
            return RedirectToAction("Error");
        }

        public ViewResult Error()
        {
            return View();
        }
    }
}
