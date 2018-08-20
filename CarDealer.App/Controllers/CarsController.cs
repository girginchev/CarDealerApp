namespace CarDealer.App.Controllers
{
    using CarDealer.App.Models.Cars;
    using CarDealer.Services;
    using CarDealer.Services.Models.Cars;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class CarsController : Controller
    {
        private readonly ICarService cars;
        private readonly IPartService parts;

        public CarsController(ICarService cars, IPartService parts)
        {
            this.cars = cars;
            this.parts = parts;
        }

        [Route("cars/all")]
        public IActionResult All()
        {
            var result = cars.All();
            return View(new CarsAllViewModel
            {
                Cars = result
            });
        }

        [Route("cars/{make}")]
        public IActionResult ByMake(string make)
        {
            var result = cars.ByMake(make);

            return View(new CarsByMakeViewModel
            {
                Cars = result,
                Make = make
            });
        }

        [Route("cars/{id}/parts")]
        public IActionResult WithParts(int id)
        {
            var result = cars.WithParts(id);

            return View(new CarWithPartsViewModel
            {
                Car = result
            });
        }

        [Route("cars/create")]
        public IActionResult Create() => View(new CarFormViewModel
        {
             Parts = parts.AllListing().Select(s => new SelectListItem
            {
                Text = s.Name,
                Value = s.Id.ToString()
            })
        });
        
  

        [HttpPost]
        [Route("cars/create")]
        public IActionResult Create(CarFormViewModel carModel)
        {
            if (!ModelState.IsValid)
            {
                return View(carModel);
            }

            cars.Create(carModel.Make, carModel.Model, carModel.TravelledDistance, carModel.PartIds);

            return RedirectToAction(nameof(All));
        }
    }
}
