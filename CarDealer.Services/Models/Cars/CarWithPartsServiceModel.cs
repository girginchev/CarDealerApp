namespace CarDealer.Services.Models.Cars
{
    using CarDealer.Services.Models.Parts;
    using System.Collections.Generic;

    public class CarWithPartsServiceModel : CarServiceModel
    {
        public int Id { get; set; }

        public IEnumerable<PartServiceModel> Parts { get; set; }
    }
}
