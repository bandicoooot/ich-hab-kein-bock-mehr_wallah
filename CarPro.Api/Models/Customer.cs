using System.Collections.Generic;

namespace CarPro.Api.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public bool NewsletterSubscribed { get; set; }

        public ICollection<PurchaseContract>? PurchaseContracts { get; set; }
    }
}
