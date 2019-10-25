using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NimbleWeb.Models;
using Microsoft.AspNetCore.Mvc;
using NimbleWeb.ViewModels;

namespace NimbleWeb.Controllers
{
    public class TestRunnerController : Controller
    {

        private readonly ITestRunnerRepository _testRunnerRepository;

        public TestRunnerController(ITestRunnerRepository testRunnerRepository)
        {
            _testRunnerRepository = testRunnerRepository;
        }

        public ViewResult Index()
        {
            var model = _testRunnerRepository.GetAll();

            return View(model);
        }

        public ViewResult Details()
        {
            TestRunnerViewModel testRunnerDetailsViewModel = new TestRunnerViewModel()
            {
                TestRunner = _testRunnerRepository.Get(1),
                PageTitle = "TestRunner Details"
            };
            return View(testRunnerDetailsViewModel);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(TestRunner testRunner)
        {
            TestRunner newTestRunner = _testRunnerRepository.Add(testRunner);
            return RedirectToAction("details", new { id = newTestRunner.Id });
        }






    }
}
