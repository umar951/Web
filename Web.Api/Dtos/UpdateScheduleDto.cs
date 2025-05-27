using System.ComponentModel.DataAnnotations;

namespace Web.Api.Dtos;

public class UpdateScheduleDto
{
    [Required]
    public int Id { get; set; }

    [Required]
    public int TrainerId { get; set; }

    [Required]
    public DateTime StartTime { get; set; }

    [Required]
    public DateTime EndTime { get; set; }

    [StringLength(200)]
    public string Description { get; set; }
}