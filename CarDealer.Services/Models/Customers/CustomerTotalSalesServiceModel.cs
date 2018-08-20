namespace CarDealer.Services.Models.Customers
{
    using CarDealer.Services.Models.Sales;
    using System.Collections.Generic;
    using System.Linq;

    public class CustomerTotalSalesServiceModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsYoungDriver { get; set; }

        public IEnumerable<SalePriceServiceModel> CarSale { get; set; }

        public int BoughtCars => CarSale.Count();
        
        public decimal TotalMoneySpent
        {
            get { return CarSale.Sum(c=>c.Price * 
                                    ((decimal)(1 - c.Discount) + (IsYoungDriver == true ? 0.5m : 0m))); }
        }
       
    }
}
