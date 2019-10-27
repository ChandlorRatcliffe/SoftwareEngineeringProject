using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashewWeb.Models;
using Microsoft.AspNetCore.Mvc;
using CashewWeb.ViewModels;

namespace CashewWeb.Controllers
{
    public class SqlScriptsController : Controller
    {

        private readonly ISqlScriptsRepository _sqlScriptsRepository;

        public SqlScriptsController(ISqlScriptsRepository sqlScriptsRepository)
        {
            _sqlScriptsRepository = sqlScriptsRepository;
        }

        public ViewResult Index()
        {
            var model = _sqlScriptsRepository.GetAll();

            return View(model);
        }

        public ViewResult Details()
        {
            SqlScriptsViewModel sqlScriptsDetailsViewModel = new SqlScriptsViewModel()
            {
                SqlScripts = _sqlScriptsRepository.Get(1),
                PageTitle = "SqlScripts Details"
            };
            return View(sqlScriptsDetailsViewModel);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(SqlScripts sqlScripts)
        {
            SqlScripts newSqlScripts = _sqlScriptsRepository.Add(sqlScripts);
            return RedirectToAction("details", new { id = newSqlScripts.Id});
        }



       


    }
}
