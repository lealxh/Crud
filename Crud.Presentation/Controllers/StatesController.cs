using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crud.Entitities;
using Crud.Implementation;
using Crud.Presentation.ViewModels;
using Crud.Services;
using Microsoft.AspNetCore.Mvc;

namespace Crud.Presentation.Controllers
{
    public class StatesController : Controller
    {
        private readonly IStateService _service;
        private readonly ICountryService _countryService;

        public StatesController(IStateService service,ICountryService countryService)
        {
            this._service = service;
            this._countryService = countryService;
        }
        public IActionResult Index()
        {
            return View(_service.GetStates());
        }

        public IActionResult Create()
        {
            var vm = new CreateStateViewModel()
            {
                CountriesList=_countryService.GetCountries().
                Select(x=>new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem {
                 Text =x.Name
                ,Value=x.Id.ToString()
                })
            };
            return View(vm);
        }

        [HttpPost]
        public IActionResult Create(State state)
        {
            if (ModelState.IsValid)
            {
                _service.Create(state);
                return RedirectToAction("Index");
            }
            return View(state);
        }

        public IActionResult Edit(int id)
        {
            var vm = new CreateStateViewModel()
            {
                CountriesList = _countryService.GetCountries().
                Select(x => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
                {
                    Text = x.Name
                ,
                    Value = x.Id.ToString()
                }),
                State=_service.GetState(id)
               
                
            };
            return View(vm);
        }

        [HttpPost]
        public IActionResult Edit(State state)
        {
            if (ModelState.IsValid)
            {
                _service.Edit(state);
                return RedirectToAction("Index");
            }
            return View(state);
        }
      


    }
}