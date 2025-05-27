namespace Web.Api.Dtos;

public class GenerateQrDto
{
    public int ClientId { get; set; }
    public decimal Amount { get; set; }
    public string Description { get; set; }
}