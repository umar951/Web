using Microsoft.AspNetCore.Mvc;
using Web.Api.Dtos;
using Web.Domain.Entities;
using Web.Infrastructure.Ef;
using Microsoft.EntityFrameworkCore;

namespace Web.Api.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ScheduleController:ControllerBase
{
    private readonly DataContext _context;

    public ScheduleController(DataContext context)
    {
        _context = context;
    }
    [HttpPost]
    public async Task<IActionResult> CreateSchedule([FromBody] ScheduleDto dto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var schedule = new Schedule
        {
            TrainerId = dto.TrainerId,
            StartTime = dto.StartTime,
            EndTime = dto.EndTime,
            Description = dto.Description
        };

        _context.Schedules.Add(schedule);
        await _context.SaveChangesAsync();

        return Ok(new { message = "Schedule created", schedule.Id });
    }
    
    [HttpPut]
    public async Task<IActionResult> UpdateSchedule([FromBody] UpdateScheduleDto dto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var schedule = await _context.Schedules.FindAsync(dto.Id);
        if (schedule == null)
            return NotFound();

        schedule.TrainerId = dto.TrainerId;
        schedule.StartTime = dto.StartTime;
        schedule.EndTime = dto.EndTime;
        schedule.Description = dto.Description;

        await _context.SaveChangesAsync();

        return Ok(new { message = "Schedule updated" });
    }
    
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteSchedule(int id)
    {
        var schedule = await _context.Schedules.FindAsync(id);
        if (schedule == null)
            return NotFound();

        _context.Schedules.Remove(schedule);
        await _context.SaveChangesAsync();

        return Ok(new { message = $"Schedule {id} deleted" });
    }
}