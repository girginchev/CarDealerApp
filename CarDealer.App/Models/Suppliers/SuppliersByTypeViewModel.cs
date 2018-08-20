namespace CarDealer.App.Models.Suppliers
{
    using CarDealer.Services.Models;
    using System.Collections.Generic;

    public class SuppliersByTypeViewModel
    {
        public string Type { get; set; }

        public IEnumerable<SupplierServiceModel> Suppliers { get; set; }
    }
}
