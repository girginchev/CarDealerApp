namespace CarDealer.Services.Models.Customers
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class CustomerServiceModel
    {
        public int  Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        [Required]
        public bool IsYoungDriver { get; set; }
    }
}
