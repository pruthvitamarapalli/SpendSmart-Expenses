using Microsoft.EntityFrameworkCore;

namespace SpendSmart.Models
{
    // inherit from DbContext class
    public class SpendSmartDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set;}

        public SpendSmartDbContext(DbContextOptions<SpendSmartDbContext> options) 
            : base(options)
        {

        }
    }
}