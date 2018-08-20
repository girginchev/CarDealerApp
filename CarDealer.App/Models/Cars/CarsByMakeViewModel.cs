namespace CarDealer.App.Models.Cars
{
    using CarDealer.Services.Models.Cars;
    using System.Collections.Generic;

    public class CarsByMakeViewModel
    {
        public string Make { get; set; }

        public IEnumerable<CarServiceModel> Cars { get; set; }
    }
}
