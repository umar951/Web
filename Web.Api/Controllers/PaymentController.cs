using Microsoft.AspNetCore.Mvc;
using Web.Api.Dtos;
using Web.Infrastructure.Ef;

namespace Web.Api.Controllers;
[ApiController]
[Route("api/[controller]")]
public class PaymentController: ControllerBase
{  
    private readonly DataContext _context;

    public PaymentController(DataContext context)
    {
        _context = context;
    }
    
    
    [HttpPost("pay-by-qr")]
    public IActionResult PayByQr([FromBody] GenerateQrDto dto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        // QR логикасы (мисалы, логирлөө, базага сактоо)
        return Ok(new
        {
            message = "QR code generated",
            qrUrl = $"https://mbank.kg/qr/{Guid.NewGuid()}"
        });
    }
    [HttpPost("pay-by-card")]
    public IActionResult PayByCard([FromBody] MbankCardPaymentDto dto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        // Карта аркылуу төлөм логикасы (мисалы, базага сактоо)
        return Ok(new
        {
            message = "Payment successful",
            transactionId = Guid.NewGuid()
        });
    }
    
    [HttpPost("callback")]
    public IActionResult PaymentCallback([FromBody] MbankCallbackDto dto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        // Колбэк логикасы (мисалы, транзакциянын статусун жаңыртуу)
        return Ok(new
        {
            status = "Callback received",
            transaction = dto.TransactionId
        });
    }
    [HttpGet]
    public IActionResult GetPayments()
    {
        var payments = _context.Payments
            .Select(p => new
            {
                p.Id,
                p.ClientId,
                p.Amount,
                p.PaymentMethod,
                p.PaymentDate,
                p.TransactionId,
                p.IsSuccessful
            })
            .ToList();

        return Ok(payments);
    }
    [HttpGet("{id}")]
    public IActionResult GetPayment(int id)
    {
        var payment = _context.Payments
            .FirstOrDefault(p => p.Id == id);

        if (payment == null)
            return NotFound(new { message = "Payment not found" });

        return Ok(payment);
    }
    [HttpDelete("{id}")]
    public IActionResult DeletePayment(int id)
    {
        var payment = _context.Payments.FirstOrDefault(p => p.Id == id);
        if (payment == null)
            return NotFound();

        _context.Payments.Remove(payment);
        _context.SaveChanges();

        return Ok(new { message = "Payment deleted" });
    }
}