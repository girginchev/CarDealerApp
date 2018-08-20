namespace CarDealer.App.Models.Parts
{
    using CarDealer.Services.Models;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class PartFormViewModel
    {
        [Required]
        public string Name { get; set; }

        [Range(0, 10000000)]
        public decimal Price { get; set; }

        [Range(0, 10000000)]
        public int Quantity { get; set; }

        [Display(Name = "Supplier")]
        public int SupplierId { get; set; }

        public IEnumerable<SelectListItem> Suppliers { get; set; }
    }
}
