namespace CarDealer.Services
{
    using CarDealer.Services.Models.Cars;
    using System.Collections.Generic;

    public interface ICarService
    {
        IEnumerable<CarWithPartsServiceModel> All();

        IEnumerable<CarServiceModel> ByMake(string make);

        CarWithPartsServiceModel WithParts(int id);

        void Create(string make, string model, long travelledDistance, IEnumerable<int> partIds);
    }
}
