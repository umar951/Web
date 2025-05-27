using System.ComponentModel.DataAnnotations;

namespace Web.Api.Dtos;

public class PaymentDto
{
    [Required]
    public int ProductId { get; set; }

    [Required]
    public decimal Amount { get; set; }

    [Required]
    public string PaymentMethod { get; set; }
}