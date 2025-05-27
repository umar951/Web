using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Api.Dtos;
using Web.Domain.Entities;
using Web.Infrastructure.Ef;

namespace Web.Api.Controllers;
[ApiController]
[Route("api/[controller]")]
public class TrainerController:ControllerBase
{
    /*private readonly DataContext _context;

    public TrainerController(DataContext context)
    {
        _context = context;
    }
    
    
[HttpPost]
    public async Task<IActionResult> CreateTrainer([FromBody] TrainerDto dto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var trainer = new Trainer
        {
            FullName = dto.FullName,
            PhoneNumber = dto.PhoneNumber,
            Email = dto.Email,
            DateOfBirth = dto.DateOfBirth,
            Specialization = dto.Specialization
        };

        await _context.Trainers.AddAsync(trainer);
        await _context.SaveChangesAsync();

        return Ok(new { message = "Trainer created", trainer.Id });
    }

    // Тренерди жаңыртуу (PUT)
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateTrainer(int id, [FromBody] TrainerDto dto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var trainer = await _context.Trainers.FindAsync(id);
        if (trainer == null)
        {
            return NotFound("Тренер табылган жок.");
        }

        trainer.FullName = dto.FullName;
        trainer.PhoneNumber = dto.PhoneNumber;
        trainer.Email = dto.Email;
        trainer.DateOfBirth = dto.DateOfBirth;
        trainer.Specialization = dto.Specialization;

        _context.Trainers.Update(trainer);
        await _context.SaveChangesAsync();

        return Ok(new { message = "Trainer updated", trainer.Id });
    }

    // Тренерди өчүрүү (DELETE)
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTrainer(int id)
    {
        var trainer = await _context.Trainers.FindAsync(id);
        if (trainer == null)
        {
            return NotFound("Тренер табылган жок.");
        }

        _context.Trainers.Remove(trainer);
        await _context.SaveChangesAsync();

        return Ok(new { message = "Trainer deleted", trainer.Id });
    }

    // Бардык тренерлерди алуу (GET)
    [HttpGet]
    public async Task<IActionResult> GetAllTrainers()
    {
        var trainers = await _context.Trainers.ToListAsync();
        return Ok(trainers);
    }

    // Тренерди ID боюнча алуу (GET)
    [HttpGet("{id}")]
    public async Task<IActionResult> GetTrainerById(int id)
    {
        var trainer = await _context.Trainers.FindAsync(id);
        if (trainer == null)
        {
            return NotFound("Тренер табылган жок.");
        }

        return Ok(trainer);
    }*/
}