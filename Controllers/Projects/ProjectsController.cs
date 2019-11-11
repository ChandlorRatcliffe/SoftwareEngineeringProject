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
        private readonly string DateFormat = "yyyy-MM-dd";
        private readonly string DateFormatCustom = "yyyy-MM-ddTH:mm:ss";

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
                PageTitle = "Projects Page",
                Date = DateTime.Now.ToString(DateFormat),
                CalendarEvents = new List<CalendarEvent> 
                {
                    new CalendarEvent("Title00", DateTime.Now.AddDays(10).ToString(DateFormatCustom)),// "Do Stuff Now"),
                    new CalendarEvent("Title01", DateTime.Now.AddDays(10).ToString(DateFormatCustom)),// "Do Stuff then"),
                    new CalendarEvent("Title02", DateTime.Now.AddDays(10).ToString(DateFormatCustom)),// "Do Stuff there"),
                    new CalendarEvent("Title03", DateTime.Now.AddDays(10).ToString(DateFormatCustom))// "Do Stuff where?"),
                    //new CalendarEvent("Title04", DateTime.Now.AddDays(10).ToString(DateFormatCustom), "Do Stuff find out"),
                    //new CalendarEvent("Title05", DateTime.Now.AddDays(10).ToString(DateFormatCustom), "Do Stuff idk"),
                    //new CalendarEvent("Title06", DateTime.Now.AddDays(10).ToString(DateFormatCustom), "Do Stuff idc"),
                    //new CalendarEvent("Title07", DateTime.Now.AddDays(10).ToString(DateFormatCustom), "Do Stuff stuff again"),
                    //new CalendarEvent("Title08", DateTime.Now.AddDays(10).ToString(DateFormatCustom), "Do Stuff other"),
                    //new CalendarEvent("Title09", DateTime.Now.AddDays(10).ToString(DateFormatCustom), "Do Stuff pending"),
                }
            };
            return View(projectsViewModel);
        }
    }
}
