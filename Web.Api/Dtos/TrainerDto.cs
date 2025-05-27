using System.ComponentModel.DataAnnotations;

namespace Web.Api.Dtos;

public class TrainerDto
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Толук аты-жөнү милдеттүү")]
    [MaxLength(100, ErrorMessage = "Аты 100 белгиден ашпашы керек")]
    public string FullName { get; set; }

    [Required(ErrorMessage = "Телефон номери талап кылынат")]
    [Phone(ErrorMessage = "Телефон номери туура эмес форматта")]
    public string PhoneNumber { get; set; }

    [Required(ErrorMessage = "Email дарек талап кылынат")]
    [EmailAddress(ErrorMessage = "Email туура эмес")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Туулган күнү талап кылынат")]
    public DateTime DateOfBirth { get; set; }

    [Required(ErrorMessage = "Адистиги талап кылынат")]
    [MaxLength(100, ErrorMessage = "Адистик 100 белгиден ашпашы керек")]
    public string Specialization { get; set; }

}