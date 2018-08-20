namespace CarDealer.Services
{
    using CarDealer.Services.Models;
    using CarDealer.Services.Models.Customers;
    using System;
    using System.Collections.Generic;

    public interface ICustomerService
    {
        IEnumerable<CustomerServiceModel> OrderedCustomers(OrderType orderType);

        CustomerTotalSalesServiceModel TotalSalesById(int id);

        void Create(string name, DateTime birthDate, bool isYoungDriver);

        CustomerServiceModel ById(int id);

        void Edit(int id, string name, DateTime birthDate, bool isYoungDriver);

        bool Exists(int id);
    }
}
