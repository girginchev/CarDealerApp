namespace CarDealer.App.Controllers
{
    using CarDealer.App.Models.Parts;
    using CarDealer.Services;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class PartsController : Controller
    {
        private readonly IPartService parts;
        private readonly ISupplierService suppliers;
        private const int PageSize = 25;

        public PartsController(IPartService parts, ISupplierService suppliers)
        {
            this.parts = parts;
            this.suppliers = suppliers;
        }
        
        public IActionResult All(int page = 1)
        {
            return View(new PartsPageListingViewModel
            {
                Parts = parts.All(page),
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(this.parts.Total() / (double)PageSize)
            });
        }

        public IActionResult Create() => View(new PartFormViewModel
        { 
         Suppliers = suppliers.AllListing().Select(s=>new SelectListItem
         {
                Text = s.Name,
                Value = s.Id.ToString()
         })
        });

        [HttpPost]
        public IActionResult Create(PartFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            this.parts.Create(model.Name, model.Price, model.Quantity, model.SupplierId);

            return RedirectToAction(nameof(All));
        }

        public IActionResult Delete(int id) => View(id);


        public IActionResult Destroy(int id)
        {
            this.parts.Delete(id);

            return RedirectToAction(nameof(All));
        }

        public IActionResult Edit(int id)
        {
            var part = parts.ById(id);

            if (part == null)
            {
                return NotFound();
            }

            return View(new PartFormViewModel
            {
                Name = part.Name,
                Price = part.Price,
                Quantity = part.Quantity,
            });
        }

        [HttpPost]
        public IActionResult Edit(int id, PartFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            parts.Edit(id, model.Price, model.Quantity);

            return RedirectToAction(nameof(All));

        }
    }
}
