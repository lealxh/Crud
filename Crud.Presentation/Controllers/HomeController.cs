using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crud.Entitities;
using Crud.Services;
using Microsoft.AspNetCore.Mvc;

namespace Crud.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICountryService _service;
        public HomeController(ICountryService service)
        {
            this._service = service;
        }
        public IActionResult Index()
        {
            return View(_service.GetCountries());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Country country)
        {
            if (ModelState.IsValid)
            {
                _service.Create(country);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Details(int id)
        {
            var country = _service.GetCountry(id);
            if (country != null)
                return View(country);

            return RedirectToAction("Index");
        }


        public IActionResult Edit(int id)
        {
            
            var country = _service.GetCountry(id);
            if (country != null)
                return View(country);


            return View();
        }

        [HttpPost]
        public IActionResult Edit(Country country)
        {

            if (ModelState.IsValid)
            {
                _service.Update(country);
                return RedirectToAction("Index");

            }
            return View(country);
        }


        public IActionResult Delete(int id)
        {
            var country = _service.GetCountry(id);
            if (country != null)
                return View(country);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(Country country)
        {
           
            _service.Delete(country.Id);
            return RedirectToAction("Index");
            
   
        }
    }
}