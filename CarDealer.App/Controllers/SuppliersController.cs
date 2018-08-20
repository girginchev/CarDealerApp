namespace CarDealer.App.Controllers
{
    using CarDealer.App.Models.Suppliers;
    using CarDealer.Services;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;

    public class SuppliersController : Controller
    {
        private readonly ISupplierService suppliers;

        public SuppliersController(ISupplierService suppliers)
        {
            this.suppliers = suppliers;
        }

        [Route("suppliers/{type?}")]
        public IActionResult ByType(string type)
        {
            if (type == null)
            {
                type = "Local";
            }
            bool local = true;
            if (type == "Local")
            {
                local = true;
            }
            else if (type == "Importers")
            {
                local = false;
            }

            var result = suppliers.All(local);

            return View(new SuppliersByTypeViewModel
            {
                Type = type,
                Suppliers = result
            });

        }
    }
}
