namespace CarDealer.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Part
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(0, 10000000)]
        public decimal Price { get; set; }

        [Range(0, 10000000)]
        public int Quantity { get; set; }

        public int SupplierId { get; set; }
        public Supplier Suplier { get; set; }

        public List<PartCar> Cars { get; set; } = new List<PartCar>();
    }
}
