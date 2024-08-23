using System.ComponentModel.DataAnnotations;

namespace SpendTracker.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public decimal Value { get; set; }

        [Required] // Description girmek zorunlu anlamina geliyor
        public string? Description { get; set; }
    }
}
