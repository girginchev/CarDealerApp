using CarDealer.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarDealer.App.Controllers
{
    public class SalesController : Controller
    {
        private readonly ISaleService sales;

        public SalesController(ISaleService sales)
        {
            this.sales = sales;
        }

        [Route("sales")]
        public IActionResult All()
        {
            return View(sales.All());
        }

        [Route("sales/{id}")]
        public IActionResult Details(int id)
        {
            return View(sales.Details(id));
        }

        [Route("sales/discounted")]
        public IActionResult Discounted()
        {
            return View(sales.Discounted());
        }
    }
}
