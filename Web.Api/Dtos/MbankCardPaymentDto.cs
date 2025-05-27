namespace Web.Api.Dtos;

public class MbankCardPaymentDto
{
    public int ClientId { get; set; }
    public decimal Amount { get; set; }
    public string CardNumber { get; set; }
    public string ExpiryDate { get; set; } // MM/YY
    public string Cvc { get; set; }
    public string Description { get; set; }
}