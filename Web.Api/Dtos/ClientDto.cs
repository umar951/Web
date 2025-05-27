using System.ComponentModel.DataAnnotations;

namespace Web.Api.Dtos;

public class ClientDto
{
    [Required, StringLength(100)]
    public string FullName { get; set; }

    [Required, Phone]
    public string PhoneNumber { get; set; }

    [Required, EmailAddress]
    public string Email { get; set; }

}