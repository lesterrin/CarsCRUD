using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarsCRUD.Models;
using CarsCRUD.Services;
using System.Globalization;
using Microsoft.Extensions.Localization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;
using CarsCRUD.Interfaces;
using Microsoft.AspNetCore.Hosting;

namespace CarsCRUD.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarServices _carServ;
        private readonly IStringLocalizer<CarController> _localizer;
        private readonly IStringLocalizer<SharedResources> _sharedLocalizer;
        public CarController(ICarServices iCarServ, IStringLocalizer<CarController> localizer,
                   IStringLocalizer<SharedResources> sharedLocalizer)
        {
            _carServ = iCarServ;
            _localizer = localizer;
            _sharedLocalizer = sharedLocalizer;
        }

        public string GetCulture()
        {
            return $"CurrentCulture:{CultureInfo.CurrentCulture.Name}, CurrentUICulture:{CultureInfo.CurrentUICulture.Name}";
        }



        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }

        public ViewResult Index()
        {
            var cars = _carServ.GetCar();
            return View(cars);
        }

        // GET: Car/Details/5
        public ViewResult Details(int id)
        {
            var car = _carServ.FindCar(id);
            return View(car);
        }


        //Get: Car/Create
        public IActionResult Create()
        {
            return View(new Car());
        }

        // GET: Car/Edit/5
        public ViewResult Edit(int id)
        {
            var car = _carServ.FindCar(id);
            return View(car);
        }

        // GET: Car/Delete/5
        public ViewResult Delete(int id)
        {
            var car = _carServ.FindCar(id);

            return View(car);
        }


        // POST: Car/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create(Car car)
        {
            if (ModelState.IsValid)
            {
                await _carServ.AddCar(car);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(car);
            }
        }

        // POST: Car/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            Car car = _carServ.FindCar(id);
            if (ModelState.IsValid)
            {
                await _carServ.RemoveCar(car);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(car);
            }
        }


        private bool CarExists(int id)
        {
            return _carServ.AnyCar(id);
        }


        // POST: Car/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Car car)
        {
            if (ModelState.IsValid)
            {
                await _carServ.UpdateCar(car);
                return RedirectToAction(nameof(Index));
            }
            return View(car);
        }


    }
}
