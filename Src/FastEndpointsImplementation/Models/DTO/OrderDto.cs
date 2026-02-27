using System.ComponentModel.DataAnnotations;

namespace FastEndpointsImplementation.Models.DTO;

public class OrderDto
{
    public int Id { get; set; }

    public DateTime OrderDate { get; set; }

    public decimal TotalAmount { get; set; }

    public int CustomerId { get; set; }
}

public class CreateOrder
{
    [Required]
    public decimal TotalAmount { get; set; }

    [Required]
    public int CustomerId { get; set; }
}
