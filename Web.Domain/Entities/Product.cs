using System.ComponentModel.DataAnnotations;
using Web.Domain.Enums;

namespace Web.Domain.Entities;

public class Product
{
    public int Id { get; set; }

    [Required, StringLength(100)]
    public string Name { get; set; }

    [Range(0, 100000)]
    public decimal Price { get; set; }

    public ProductType Type { get; set; }

    public PaymentInterval PaymentInterval { get; set; }

    // Абонемент үчүн (мисалы, 30 күн)
    public int? DurationInDays { get; set; }

    // Товар үчүн (мисалы, 1 литр суу)
    public int? Quantity { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public ICollection<Subscription> Subscriptions { get; set; }

    // Байланыштар
    public ICollection<Payment> Payments { get; set; }
}