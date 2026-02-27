using Microsoft.EntityFrameworkCore;

namespace FastEndpointsImplementation.Models.Entities;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
}