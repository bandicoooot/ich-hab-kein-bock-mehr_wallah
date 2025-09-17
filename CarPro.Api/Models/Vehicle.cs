using System.ComponentModel.DataAnnotations;

namespace CarPro.Api.Models
{
    public enum VehicleStatus
    {
        Available,
        Reserved,
        Sold
    }

    public class Vehicle
    {
        [Key]   
        public int VehicleId { get; set; }
        public string? Brand { get; set; }
        public string? Type { get; set; }
        public string? Color { get; set; }
        public string? Features { get; set; }
        public ICollection<PurchaseContract>? PurchaseContracts { get; set; }

    }
}
