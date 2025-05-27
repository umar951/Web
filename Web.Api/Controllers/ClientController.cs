using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Api.Dtos;
using Web.Domain.Entities;
using Web.Infrastructure.Ef;

namespace Web.Api.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ClientController:ControllerBase
{
    
    private readonly DataContext _context;

    public ClientController(DataContext context)
    {
        _context = context;
    }
    [HttpGet]
    public async Task<IActionResult> GetClients()
    {
        var clients = await _context.Clients.ToListAsync();
        return Ok(clients);
    }
    [HttpPost]
    public async Task<IActionResult> RegisterClient([FromBody] ClientDto dto)
    {
        var client = new Client
        {
            FullName = dto.FullName,
            PhoneNumber = dto.PhoneNumber,
            Email = dto.Email,
            
            RegisterAt = DateTime.UtcNow
        };

        _context.Clients.Add(client);
        await _context.SaveChangesAsync();

        return Ok(client);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetClient(int id)
    {
        var client = await _context.Clients.FindAsync(id);
        if (client == null)
        {
            return NotFound();
        }
        return Ok(client);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateClient(int id, [FromBody] ClientDto dto)
    {
        var client = await _context.Clients.FindAsync(id);

        if (client == null)
            return NotFound("Клиент табылган жок");

        // Дал келбеген болсо, кайтарабыз
        // (Эгер dto.Id болсо, текшерип салыштырыш керек болмок)

        // Маалыматтарды жаңыртабыз
        client.FullName = dto.FullName;
        client.PhoneNumber = dto.PhoneNumber;
        client.Email = dto.Email;
        

        // Базаны сактайбыз
        await _context.SaveChangesAsync();

        return Ok("Клиент ийгиликтүү жаңыртылды");
    }
}