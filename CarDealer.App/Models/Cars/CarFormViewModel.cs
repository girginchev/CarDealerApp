namespace CarDealer.App.Models.Cars
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CarFormViewModel
    {
        [Required]
        [MaxLength(20)]
        public string Make { get; set; }

        [Required]
        [MaxLength(20)]
        public string Model { get; set; }

        [Range(0,long.MaxValue, ErrorMessage = "Travelled distance must be positive number")]
        public long TravelledDistance { get; set; }


        [Display(Name = "Parts")]
        public IEnumerable<int> PartIds { get; set; }

        public IEnumerable<SelectListItem> Parts { get; set; }
    }
}
