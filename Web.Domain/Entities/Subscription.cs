using System.ComponentModel.DataAnnotations;

namespace Web.Domain.Entities;

public class Subscription
{
    public int Id { get; set; }

    [Required, StringLength(100)]
    public string Name { get; set; }
    public int ClientId { get; set; }
    public Client Client { get; set; } // Навигация

    public int ProductId { get; set; }
    public Product Product { get; set; } 

    [Range(0, 100000)]
    public decimal Price { get; set; }
    
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsActive { get; set; }

    [Range(1, 365)]
    public int DurationDays { get; set; }

   
}