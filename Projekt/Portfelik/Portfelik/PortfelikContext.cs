using Microsoft.EntityFrameworkCore;

public class PortfelikContext(DbContextOptions<PortfelikContext> options) : DbContext(options)
{
    public DbSet<Portfelik.Models.Expense> Expense { get; set; } = default!;
}
