using System.ComponentModel.DataAnnotations;

namespace FastEndpointsImplementation.Models.DTO;

public class UpdateCustomer
{
    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(100)]
    public string LastName { get; set; }

    [Required]
    [EmailAddress]
    [MaxLength(150)]
    public string Email { get; set; }

    [Phone]
    [MaxLength(20)]
    public string PhoneNumber { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public bool IsActive { get; set; }
}
