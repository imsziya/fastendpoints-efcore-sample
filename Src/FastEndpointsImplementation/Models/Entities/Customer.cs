using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastEndpointsImplementation.Models.Entities;

[Table("Customers")]
public class Customer
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    [Column("FirstName", TypeName = "nvarchar(100)")]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(100)]
    [Column("LastName", TypeName = "nvarchar(100)")]
    public string LastName { get; set; }

    [Required]
    [EmailAddress]
    [MaxLength(150)]
    [Column("Email", TypeName = "nvarchar(150)")]
    public string Email { get; set; }

    [Phone]
    [MaxLength(20)]
    [Column("PhoneNumber", TypeName = "nvarchar(20)")]
    public string PhoneNumber { get; set; }

    [Column("DateOfBirth", TypeName = "date")]
    public DateTime? DateOfBirth { get; set; }

    [Required]
    [Column("CreatedAt")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [Column("IsActive")]
    public bool IsActive { get; set; } = true;

    public ICollection<Order> Orders { get; set; }
}