using System.ComponentModel.DataAnnotations;

namespace CarPro.Api.Models
{
    public class PurchaseContract
    {
        [Key]
        public int ContractId { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }


        public int VehicleId { get; set; }
        public Vehicle? Vehicle { get; set; }


        public DateTime PurchaseDate { get; set; }
        public decimal Price { get; set; }
    }
}
