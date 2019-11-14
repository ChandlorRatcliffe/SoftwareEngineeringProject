﻿using System;
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
        public ViewResult Index()
        {
            ProjectsViewModel projectsViewModel = new ProjectsViewModel()
            {
                PageTitle = "Projects Page"
            };
            return View(projectsViewModel);
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
    }
}
