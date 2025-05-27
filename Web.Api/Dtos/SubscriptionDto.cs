using System.ComponentModel.DataAnnotations;

namespace Web.Api.Dtos;

public class SubscriptionDto
{    public int Id { get; set; }

    public int ClientId { get; set; }
    public string ClientName { get; set; }

    public int ProductId { get; set; }
    public string ProductName { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public bool IsActive { get; set; }
}