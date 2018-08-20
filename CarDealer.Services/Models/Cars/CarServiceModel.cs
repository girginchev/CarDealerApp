namespace CarDealer.Services.Models.Cars
{
    using System.ComponentModel.DataAnnotations;

    public class CarServiceModel
    {
        [Required]
        [MaxLength(20)]
        public string Make { get; set; }

        [Required]
        [MaxLength(20)]
        public string Model { get; set; }

        public long TravelledDistance { get; set; }
    }
}