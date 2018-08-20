namespace CarDealer.App.Models.Customers
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class CustomerViewModel
    {

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        [Required]
        public bool IsYoungDriver { get; set; }
    }
}
