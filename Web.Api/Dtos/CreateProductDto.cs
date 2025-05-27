using System.ComponentModel.DataAnnotations;
using Web.Domain.Enums;

namespace Web.Api.Dtos;

public class CreateProductDto
{
    
    [Required, StringLength(100)]
    public string Name { get; set; }

    [Range(0, 100000)]
    public decimal Price { get; set; }

    [Required]
    public ProductType Type { get; set; }

    public int? DurationInDays { get; set; } // Абонементтер үчүн

    public int? Quantity { get; set; } // Товарлар үчүн

    [Required]
    public PaymentInterval PaymentInterval { get; set; }
}