namespace CarDealer.App.Models.Cars
{
    using CarDealer.Services.Models.Cars;
    using System.Collections.Generic;

    public class CarsAllViewModel
    {
        public IEnumerable<CarWithPartsServiceModel> Cars { get; set; }
    }
}
