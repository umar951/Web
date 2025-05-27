using System.ComponentModel.DataAnnotations;
using Web.Domain.Enums;

namespace Web.Api.Dtos;

public class ProductDto
{
    [Required, StringLength(100)]
    public string Name { get; set; }

    [Range(0, 100000)]
    public decimal Price { get; set; }

    public ProductType Type { get; set; }

    public int? DurationInDays { get; set; } // Абонементтер үчүн

    public int? Quantity { get; set; } // Товарлар үчүн

    public PaymentInterval PaymentInterval { get; set; }
}