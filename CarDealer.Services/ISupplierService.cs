namespace CarDealer.Services
{
    using CarDealer.Services.Models;
    using System.Collections.Generic;

    public interface ISupplierService
    {
        IEnumerable<SupplierServiceModel> All(bool isImoporter);

        IEnumerable<SupplierServiceModel> AllListing();
    }
}
