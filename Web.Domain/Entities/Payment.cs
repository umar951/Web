using System.ComponentModel.DataAnnotations;

namespace Web.Domain.Entities;

public class Payment
{
    public int Id { get; set; }

    [Required]
    public int ClientId { get; set; }
    public Client Client { get; set; }
    [Required]
    public int ProductId { get; set; }
    public Product Product { get; set; }

    [Range(0, 100000)]
    public decimal Amount { get; set; }

    [Required, StringLength(50)]
    public string PaymentMethod { get; set; } // e.g., Mbank, Cash

    public DateTime PaymentDate { get; set; } = DateTime.UtcNow;

    [Required, StringLength(100)]
    public string TransactionId { get; set; }

    public bool IsSuccessful { get; set; } 
}