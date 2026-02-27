namespace FastEndpointsImplementation.Models.DTO;

public class CustomerDto
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public bool IsActive { get; set; }

    public List<OrderDto> Orders { get; set; }
}