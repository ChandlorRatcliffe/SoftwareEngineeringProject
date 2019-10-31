using System;
using System.Collections.Generic;
using System.Linq;
using CashewWeb.Models;
using Microsoft.AspNetCore.Mvc;
using CashewWeb.ViewModels;

namespace CashewWeb.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly IProjectsRepository _projectsRepository;

        public ProjectsController(IProjectsRepository projectsRepository)
        {
            _projectsRepository = projectsRepository;

        }

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
