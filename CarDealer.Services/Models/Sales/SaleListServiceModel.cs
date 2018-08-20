namespace CarDealer.Services.Models.Sales
{
    public class SaleListServiceModel : SalePriceServiceModel
    {
        public int Id { get; set; }

        public string CustomerName { get; set; }

        public bool IsYoungDriver { get; set; }

        public decimal DiscountedPrice =>
            this.Price * (1 - ((decimal)this.Discount + (IsYoungDriver ? 0.05m : 0)));
    }
}
