using CarDealer.Services.Models.Cars;

namespace CarDealer.Services.Models.Sales
{
    public class SaleDetailsServiceModel : SaleListServiceModel
    {
        public CarServiceModel Car { get; set; }
    }
}
