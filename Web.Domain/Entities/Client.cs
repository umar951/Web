using System.ComponentModel.DataAnnotations;

namespace Web.Domain.Entities;

public class Client
{
    public int Id { get; set; }

    [Required, StringLength(100)]
    public string FullName { get; set; }

    [Required, Phone]
    public string PhoneNumber { get; set; }

    [Required, EmailAddress]
    public string Email { get; set; }


    public DateTime RegisterAt { get; set; } = DateTime.UtcNow;
    public ICollection<Subscription> Subscriptions { get; set; }
    public ICollection<Payment> Payments { get; set; }
}