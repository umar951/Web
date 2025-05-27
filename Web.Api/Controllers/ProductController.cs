using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Api.Dtos;
using Web.Domain.Entities;
using Web.Infrastructure.Ef;

namespace Web.Api.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ProductController: ControllerBase
{
    
    private readonly DataContext _context;

    public ProductController(DataContext context)
    {
        _context = context;
    }
    [HttpPost]
    public async Task<IActionResult> CreateProduct([FromBody] CreateProductDto dto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var product = new Product
        {
            Name = dto.Name,
            Price = dto.Price,
            Type = dto.Type,
            DurationInDays = dto.DurationInDays,
            Quantity = dto.Quantity,
            PaymentInterval = dto.PaymentInterval
        };

        _context.Products.Add(product);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetProducts()
    {
        var products = await _context.Products
            .Select(p => new
            {
                p.Id,
                p.Name,
                p.Price,
                p.Quantity
            }).ToListAsync();

        return Ok(products);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetProduct(int id)
    {
        var product = await _context.Products.FindAsync(id);
        if (product == null)
            return NotFound();

        return Ok(new
        {
            product.Id,
            product.Name,
            product.Price,
            product.Quantity
        });
    }
    
    
    [HttpPut]
    public async Task<IActionResult> UpdateProduct([FromBody] UpdateProductDto dto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var product = await _context.Products.FindAsync(dto.Id);
        if (product == null)
            return NotFound();

        product.Name = dto.Name;
        product.Price = dto.Price;
        product.Quantity = dto.Quantity;

        await _context.SaveChangesAsync();

        return Ok(new { message = "Product updated" });
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProduct(int id)
    {
        var product = await _context.Products.FindAsync(id);
        if (product == null)
            return NotFound();

        _context.Products.Remove(product);
        await _context.SaveChangesAsync();

        return Ok(new { message = $"Product {id} deleted" });
    }

}