namespace CarDealer.Services.Implementations
{
    using System.Collections.Generic;
    using System.Linq;
    using CarDealer.App.Data;
    using CarDealer.Data.Models;
    using CarDealer.Services.Models.Cars;
    using CarDealer.Services.Models.Parts;

    public class CarService : ICarService
    {
        private readonly CarDealerDbContext db;

        public CarService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<CarWithPartsServiceModel> All()
         => db.Cars.Select(c => new CarWithPartsServiceModel
         {
             Id = c.Id,
             Make = c.Make,
             Model = c.Model,
             TravelledDistance = c.TravelledDistance

         });

        public IEnumerable<CarServiceModel> ByMake(string make)
             => db.Cars
                .Where(c => c.Make.ToLower() == make.ToLower())
                .OrderBy(c => c.Model)
                .ThenBy(c => c.TravelledDistance)
                    .Select(c => new CarServiceModel
                    {
                        Make = c.Make,
                        Model = c.Model,
                        TravelledDistance = c.TravelledDistance
                    })
                    .ToList();

        public void Create(string make, string model, long travelledDistance, IEnumerable<int> partIds)
        {
           
            var car = new Car
            {
                Make = make,
                Model = model,
                TravelledDistance = travelledDistance
            };
            db.Cars.Add(car);

            foreach (var partId in partIds)
            {
                var partCar = new PartCar
                {
                    CarId = car.Id,
                    PartId = partId
                };
                db.PartCars.Add(partCar);
            }
            db.SaveChanges();
        }

        public CarWithPartsServiceModel WithParts(int id)
        {
            return db.Cars
                .Where(c => c.Id == id)
                .Select(c => new CarWithPartsServiceModel
                {
                    Id = c.Id,
                    Make = c.Make,
                    Model = c.Model,
                    TravelledDistance = c.TravelledDistance,
                    Parts = c.Parts
                        .Select(p => new PartServiceModel
                        {
                            Name = p.Part.Name,
                            Price = p.Part.Price
                        })
                        .ToList()
                }).FirstOrDefault();
        }
    }
}
