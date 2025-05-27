using System.ComponentModel.DataAnnotations;

namespace Web.Domain.Entities;

public class Schedule
{
    public int Id { get; set; }

    [Required]
    public int TrainerId { get; set; }
    public Trainer Trainer { get; set; }

    [Required]
    public DateTime StartTime { get; set; }

    [Required]
    public DateTime EndTime { get; set; }

    [StringLength(200)]
    public string Description { get; set; }
}