namespace Web.Api.Dtos;

public class MbankCallbackDto
{
    public string TransactionId { get; set; }
    public bool IsSuccessful { get; set; }
    public string Message { get; set; }
}