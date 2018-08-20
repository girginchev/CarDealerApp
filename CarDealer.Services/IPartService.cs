using CarDealer.Services.Models.Parts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer.Services
{
    public interface IPartService
    {
        IEnumerable<PartListingServiceModel> All(int page = 1);

        int Total();

        void Create(string name, decimal price, int quantity, int supplierId);
         
        void Delete(int id);

        PartFormServiceModel ById(int id);

        void Edit(int id, decimal price, int quantity);

        IEnumerable<PartsAllServiceModel> AllListing();
    }
}
