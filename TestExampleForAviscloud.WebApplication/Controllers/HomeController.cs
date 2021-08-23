using Microsoft.AspNetCore.Mvc;
using System;
using TestExampleForAviscloud.Model.Storage;
using TestExampleForAviscloud.Model.Storage.Entities;
using TestExampleForAviscloud.WebApplication.Models;

namespace TestExampleForAviscloud.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager _dataManager;

        public HomeController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var viewModel = new WorkersViewModel()
            {
                Worker = new Worker(),
                MinDateOfBirth = DateTime.Now.AddYears(-100),
                MaxDateOfBirth = DateTime.Now.AddYears(-14),
                Workers = _dataManager.Workers.GetWorkers(),
                Genders = _dataManager.Genders.GetGenders()
            };

            return View(viewModel);
        }

        [HttpPost]
        public PartialViewResult Browse()
        {
            var viewModel = new WorkersViewModel()
            {
                Worker = new Worker(),
                MinDateOfBirth = DateTime.Now.AddYears(-100),
                MaxDateOfBirth = DateTime.Now.AddYears(-14),
                Workers = _dataManager.Workers.GetWorkers(),
                Genders = _dataManager.Genders.GetGenders()
            };

            return PartialView("_BrowseWorkersPartial", viewModel);
        }

        [HttpPost]
        public PartialViewResult Info(Guid id)
        {
            var viewModel = new WorkersViewModel()
            {
                Worker = _dataManager.Workers.GetWorkerById(id),
                MinDateOfBirth = DateTime.Now.AddYears(-100),
                MaxDateOfBirth = DateTime.Now.AddYears(-14),
                Genders = _dataManager.Genders.GetGenders()
            };

            return PartialView("_FormWorkerPartial", viewModel);
        }

        [HttpPost]
        public PartialViewResult Save(WorkersViewModel viewModel)
        {
            if(viewModel?.Worker != null)
            {
                if (ModelState.IsValid)
                {
                    if (_dataManager.Workers.SaveWorker(viewModel.Worker))
                    {
                        return PartialView("_NullFormWorkerPartial");
                    }
                    else
                    {
                        ModelState.AddModelError("Worker.Name", "Пользователь с такими данными уже существует.");
                        ModelState.AddModelError("Worker.Email", "Пользователь с такими данными уже существует.");
                    }
                }
            }

            return PartialView("_FormWorkerPartial", viewModel);
        }
    }
}
