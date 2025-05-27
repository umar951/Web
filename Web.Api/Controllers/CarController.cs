using Microsoft.AspNetCore.Mvc;
using Web.Domain.Entities;
using Web.Infrastructure.Ef;

namespace Web.Api.Controllers;
[ApiController]
[Route("api/products")] 
public class CarController:ControllerBase
{
   private readonly  DataContext _context ;

   public CarController(DataContext context)
   {
      _context = context;
   }
   
   // 🛠 1️⃣ Бардык унааларды алуу  [HttpGet]
   [HttpGet("products")]
   public IActionResult GetAllProducts()
   {
      var products = _context.Cars.ToList();
      return Ok(products);
   }
   [HttpGet("{id}")]
   public async Task<IActionResult> GetCarById(long id)
   {
      var car = await _context.Cars.FindAsync(id);
      if (car == null)
         return NotFound(new { Message = "Машина табылган жок!" });

      return Ok(car);
   }
   [HttpPost]
   public async Task<IActionResult> CreateCar([FromBody] Car car)
   {
      if (!ModelState.IsValid)
         return BadRequest(ModelState);

      _context.Cars.Add(car);
      await _context.SaveChangesAsync();
      return CreatedAtAction(nameof(GetCarById), new { id = car.Id }, car);
   }
   
   [HttpPut("{id}")]
   public async Task<IActionResult> UpdateCar(long id, [FromBody] Car car)
   {
      var existingCar = await _context.Cars.FindAsync(id);
      if (existingCar == null)
         return NotFound(new { Message = "Машина табылган жок!" });

      existingCar.Name = car.Name;
      existingCar.Year = car.Year;
      await _context.SaveChangesAsync();

      return Ok(existingCar);
   }
   [HttpDelete("{id}")]
   public async Task<IActionResult> DeleteCar(long id)
   {
      var car = await _context.Cars.FindAsync(id);
      if (car == null)
         return NotFound(new { Message = "Машина табылган жок!" });

      _context.Cars.Remove(car);
      await _context.SaveChangesAsync();

      return Ok(new { Message = "Машина өчүрүлдү!" });
   }
}