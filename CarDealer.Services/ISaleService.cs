using CarDealer.Services.Models.Sales;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer.Services
{
    public interface ISaleService
    {
        IEnumerable<SaleListServiceModel> All();

        SaleDetailsServiceModel Details(int id);

        IEnumerable<SaleListServiceModel> Discounted();
    }
}
