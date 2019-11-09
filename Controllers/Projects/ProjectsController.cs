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
        /// Tasks Landing Page, Passes TasksViewModel to Page for Dependency Checking - Nick
        /// By the wireframe, Dashboard (Projects Page) does not show tasks and so should not
        /// pass the TasksViewModel. It shows the list of projects a user is assigned to, and 
        /// so should pass the ProjectsViewModel or something similar. - Travis
        /// </summary>
        /// <returns>ViewResult</returns>
        public ViewResult Index()
        {
            ProjectsViewModel projectsViewModel = new ProjectsViewModel()
            {
                PageTitle = "Projects Page"
            };
            return View(projectsViewModel);
        }
    }
}
