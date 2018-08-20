namespace CarDealer.Services.Implementations
{
    using System.Collections.Generic;
    using System.Linq;
    using CarDealer.App.Data;
    using CarDealer.Services.Models;

    public class SupplierSurviceModel : ISupplierService
    {
        private readonly CarDealerDbContext db;

        public SupplierSurviceModel(CarDealerDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<SupplierServiceModel> All(bool isImoporter)
        {
            return db.Suppliers
                .Where(s => s.IsImporter == isImoporter)
                .Select(s => new SupplierServiceModel
                {
                    Id = s.Id,
                    Name = s.Name,
                    TotalParts = s.Parts.Count()
                })
                .ToList();
        }

        public IEnumerable<SupplierServiceModel> AllListing()
        {
            return db.Suppliers
                .OrderBy(s=>s.Name)
                .Select(s => new SupplierServiceModel
                {
                    Id = s.Id,
                    Name = s.Name
                })
                .ToList();
        }
    }
}
