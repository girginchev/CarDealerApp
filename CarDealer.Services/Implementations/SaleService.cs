using System.Collections.Generic;
using System.Linq;
using CarDealer.App.Data;
using CarDealer.Services.Models.Cars;
using CarDealer.Services.Models.Sales;

namespace CarDealer.Services.Implementations
{
    public class SaleService : ISaleService
    {
        private readonly CarDealerDbContext db;

        public SaleService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<SaleListServiceModel> All()
        {
            var result = db.Sales.Select(s => new SaleListServiceModel
            {
                Id = s.Id,
                CustomerName = s.Customer.Name,
                Discount = s.Discount,
                IsYoungDriver = s.Customer.IsYoungDriver,
                Price = s.Car.Parts.Sum(p => p.Part.Price)
            }).ToList();
            return result;
        }

        public SaleDetailsServiceModel Details(int id)
        {
            return db.Sales
                .Where(s => s.Id == id)
                .Select(s => new SaleDetailsServiceModel
                {
                    Id = s.Id,
                    CustomerName = s.Customer.Name,
                    IsYoungDriver = s.Customer.IsYoungDriver,
                    Discount = s.Discount,
                    Price = s.Car.Parts.Sum(p => p.Part.Price),
                    Car = new CarServiceModel
                    {
                        Make = s.Car.Make,
                        Model = s.Car.Model,
                        TravelledDistance = s.Car.TravelledDistance
                    }
                }).FirstOrDefault();
        }

        public IEnumerable<SaleListServiceModel> Discounted()
        {
            var result = db.Sales
                .Where(s=>s.Discount > 0)
                .OrderByDescending(s=>s.Discount)
                .Select(s => new SaleListServiceModel
            {
                Id = s.Id,
                CustomerName = s.Customer.Name,
                Discount = s.Discount,
                IsYoungDriver = s.Customer.IsYoungDriver,
                Price = s.Car.Parts.Sum(p => p.Part.Price)
            }).ToList();
            return result;
        }
    }
}
