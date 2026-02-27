using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastEndpointsImplementation.Models.Entities;

[Table("Orders")]
public class Order
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [Column("OrderDate")]
    public DateTime OrderDate { get; set; } = DateTime.UtcNow;

    [Required]
    [Column("TotalAmount", TypeName = "decimal(18,2)")]
    public decimal TotalAmount { get; set; }
    
    [ForeignKey("Customer")]
    public int CustomerId { get; set; }

   public Customer Customer { get; set; }
}