namespace Web.Api.Dtos;

public class ScheduleDto
{
    public int Id { get; set; } // Бул сап сөзсүз керек
    public int TrainerId { get; set; }
    public DateTime StartTime { get; set; }
    
    public DateTime EndTime { get; set; }
    public string Description { get; set; }
}