
namespace CarDealer.Services.Implementations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CarDealer.App.Data;
    using CarDealer.Data.Models;
    using CarDealer.Services.Models.Parts;

    public class PartService : IPartService
    {
        private const int PageSize = 25;
        private readonly CarDealerDbContext db;

        public PartService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<PartListingServiceModel> All(int page = 1)
        {
            return db.Parts
                .OrderByDescending(p => p.Id)
                .Skip((page - 1) * PageSize)
                .Take(PageSize)
                .Select(p => new PartListingServiceModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Quantity = p.Quantity,
                    SupplierName = p.Suplier.Name
                }).ToList();
        }

        public IEnumerable<PartsAllServiceModel> AllListing()
                => db.Parts.OrderBy(p => p.Id).Select(p => new PartsAllServiceModel
                        {
                            Id = p.Id,
                            Name = p.Name
                        }).ToList();

        public PartFormServiceModel ById(int id)
            => db.Parts.Where(p => p.Id == id)
                    .Select(p => new PartFormServiceModel
                    {
                        Name = p.Name,
                        Price = p.Price,
                        Quantity = p.Quantity
                    }).FirstOrDefault();

        public void Create(string name, decimal price, int quantity, int supplierId)
        {
            var part = new Part
            {
                Name = name,
                Price = price,
                Quantity = quantity > 0 ? quantity : 1,
                SupplierId = supplierId
            };
            db.Parts.Add(part);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var part = db.Parts.Find(id);

            if (part == null)
            {
                return;
            }

            db.Parts.Remove(part);
            db.SaveChanges();
        }

        public void Edit(int id, decimal price, int quantity)
        {
            var part = db.Parts.Find(id);

            if (part == null)
            {
                return;
            }

            part.Price = price;
            part.Quantity = quantity;

            db.SaveChanges();
        }

        public int Total()
        => db.Parts.Count();
    }
}
