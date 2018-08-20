namespace CarDealer.Services.Models.Parts
{
    using System.ComponentModel.DataAnnotations;

    public class PartServiceModel
    {
        [Required]
        public string Name { get; set; }

        [Range(0, 10000000)]
        public decimal Price { get; set; }
    }
}
