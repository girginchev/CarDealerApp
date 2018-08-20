namespace CarDealer.Services.Implementations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CarDealer.App.Data;
    using CarDealer.Data.Models;
    using CarDealer.Services.Models;
    using CarDealer.Services.Models.Customers;
    using Models.Sales;

    public class CustomerService : ICustomerService
    {
        private readonly CarDealerDbContext db;

        public CustomerService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public CustomerServiceModel ById(int id)
        {
            return db.Customers.Where(c => c.Id == id)
                .Select(c => new CustomerServiceModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    BirthDate = c.BirthDate,
                    IsYoungDriver = c.IsYoungDriver
                })
                .FirstOrDefault();
            
        }

        public void Create(string name, DateTime birthDate, bool isYoungDriver)
        {
            var customer = new Customer
            {
                Name = name,
                BirthDate = birthDate,
                IsYoungDriver = isYoungDriver
            };
            db.Customers.Add(customer);
            db.SaveChanges();   
        }

        public void Edit(int id, string name, DateTime birthDate, bool isYoungDriver)
        {
            var customer = db.Customers.Find(id);

            if (customer == null)
            {
                return;
            }

            customer.Name = name;
            customer.BirthDate = birthDate;
            customer.IsYoungDriver = isYoungDriver;
            db.SaveChanges();
        }

        public bool Exists(int id)
            => db.Customers.Any(c => c.Id == id);

        public IEnumerable<CustomerServiceModel> OrderedCustomers(OrderType orderType)
        {
            var customers = db.Customers.AsQueryable();

            switch (orderType)
            {
                case OrderType.Ascending:
                    customers = customers.OrderBy(c => c.BirthDate).ThenBy(c=>c.Name);
                    break;
                case OrderType.Descending:
                    customers = customers.OrderByDescending(c => c.BirthDate).ThenBy(c=>c.Name);
                    break;
                default:
                    throw new InvalidOperationException("Invalid order direction");
            }

            return customers.Select(c => new CustomerServiceModel
            {
                 Id = c.Id,
                 BirthDate = c.BirthDate,
                  Name = c.Name,
                   IsYoungDriver = c.IsYoungDriver
            }).ToList();
        }

        public CustomerTotalSalesServiceModel TotalSalesById(int id)
        {
            return db.Customers
                .Where(c => c.Id == id)
                .Select(c => new CustomerTotalSalesServiceModel
                    {
                        Id = c.Id,
                        Name = c.Name,
                         IsYoungDriver = c.IsYoungDriver,
                          CarSale = c.Sales.Select(s=> new SalePriceServiceModel
                          {
                               Price = s.Car.Parts.Sum(p=>p.Part.Price),
                                Discount = s.Discount
                          })
                    })
                    .FirstOrDefault();
        }
    }
}
