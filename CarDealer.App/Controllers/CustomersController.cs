namespace CarDealer.App.Controllers
{
    using CarDealer.App.Models;
    using CarDealer.App.Models.Customers;
    using CarDealer.Services;
    using CarDealer.Services.Models;
    using Microsoft.AspNetCore.Mvc;

    public class CustomersController : Controller
    {
        private readonly ICustomerService customers;

        public CustomersController(ICustomerService customers)
        {
            this.customers = customers;
        }

        [Route("customers/create")]
        public IActionResult Create() => View();

        [HttpPost]
        [Route("customers/create")]
        public IActionResult Create(CustomerViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            customers.Create(model.Name, model.BirthDate, model.IsYoungDriver);

            return RedirectToAction(nameof(All));
        }

        [Route("customers/edit/{id}")]
        public IActionResult Edit(int id)
        {
            var customer = customers.ById(id);

            if (customer == null)
            {
                return NotFound();
            }

            return View(new CustomerViewModel
            {
                Name = customer.Name,
                BirthDate = customer.BirthDate,
                IsYoungDriver = customer.IsYoungDriver
            });
        }

        [HttpPost]
        [Route("customers/edit/{id}")]
        public IActionResult Edit(int id, CustomerViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var customerExists = customers.Exists(id);

            if (!customerExists)
            {
                return NotFound();
            }

            customers.Edit(id, model.Name, model.BirthDate, model.IsYoungDriver);

            return RedirectToAction(nameof(All));
        }

        [Route("customers/all/{orderType?}")]
        public IActionResult All(string orderType)
        {
            var orderDirection = orderType == "descending" ? OrderType.Descending : OrderType.Ascending;

            var result  = customers.OrderedCustomers(orderDirection);

            return View(new CustomerOrderViewModel
            {
                AllCustomers = result,
                OrderType = orderDirection
            });
        }

        [Route("customers/{id}")]
        public IActionResult TotalSales(int id)
        {
            return View(customers.TotalSalesById(id));
        }
    }
}
