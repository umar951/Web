using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Api.Dtos;
using Web.Domain.Entities;
using Web.Infrastructure.Ef;

namespace Web.Api.Controllers;
[ApiController]
[Route("{controller/id}")]
public class SubscriptionController:ControllerBase
{
    /*private readonly DataContext _context;

    public SubscriptionController(DataContext context)
    {
        _context = context;
    }
    [HttpGet("dto")]
    public async Task<IActionResult> GetAllSubscriptionsDto()
    {
        var subscriptions = await _context.Subscriptions
            .Include(s => s.Client)
            .Include(s => s.Product)
            .Select(s => new SubscriptionDto
            {
                Id = s.Id,
                ClientId = s.ClientId,
                ClientName = s.Client.FullName,
                ProductId = s.ProductId,
                ProductName = s.Product.Name,
                StartDate = s.StartDate,
                EndDate = s.EndDate,
                IsActive = s.IsActive
            })
            .AsNoTracking()
            .ToListAsync();

        return Ok(subscriptions);
    }
    [HttpGet("full")]
    public async Task<IActionResult> GetAllSubscriptionsFull()
    {
        var subscriptions = await _context.Subscriptions
            .Include(s => s.Client)
            .Include(s => s.Product)
            .AsNoTracking()
            .ToListAsync();

        return Ok(subscriptions);
    }
    [HttpPost]
    public async Task<IActionResult> CreateSubscription([FromBody] SubscriptionDto dto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var subscription = new Subscription
        {
            ClientId = dto.ClientId,
            ProductId = dto.ProductId,
            StartDate = dto.StartDate,
            EndDate = dto.EndDate,
            IsActive = dto.IsActive
        };

        await _context.Subscriptions.AddAsync(subscription);
        await _context.SaveChangesAsync();

        return Ok(new { message = "Subscription created", subscription.Id });
    }

    [HttpPut]
    public async Task<IActionResult> UpdateSubs( int id,[FromBody] SubscriptionDto dto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var subscription=await _context.Subscriptions.FindAsync(id);
        if (subscription == null)
        {
            return NotFound("Абонемент табылган жок.");
        }
        subscription.ClientId = dto.ClientId;
        subscription.ProductId = dto.ProductId;
        subscription.StartDate = dto.StartDate;
        subscription.EndDate = dto.EndDate;
        subscription.IsActive = dto.IsActive;

        _context.Subscriptions.Update(subscription);
        await _context.SaveChangesAsync();

        return Ok(new { message = "Subscription updated", subscription.Id });
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteSubscription(int id)
    {
        var subscription = await _context.Subscriptions.FindAsync(id);
        if (subscription == null)
        {
            return NotFound("Абонемент табылган жок.");
        }

        // Абонементти өчүрүү
        _context.Subscriptions.Remove(subscription);
        await _context.SaveChangesAsync();

        return Ok(new { message = "Subscription deleted", subscription.Id });
    }*/
}