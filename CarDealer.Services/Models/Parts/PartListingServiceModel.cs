namespace CarDealer.Services.Models.Parts
{
    public class PartListingServiceModel : PartServiceModel
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        public string SupplierName { get; set; }
    }
}
