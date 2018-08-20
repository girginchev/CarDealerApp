namespace CarDealer.App.Models.Customers
{
    using CarDealer.Services.Models;
    using CarDealer.Services.Models.Customers;
    using System.Collections.Generic;

    public class CustomerOrderViewModel
    {
        public IEnumerable<CustomerServiceModel> AllCustomers { get; set; }

        public OrderType OrderType { get; set; }
    }
}
