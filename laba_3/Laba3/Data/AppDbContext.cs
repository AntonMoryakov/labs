using Microsoft.EntityFrameworkCore;
using Laba3.Models;

namespace Laba3.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Employee> Employee { get; set; } = default!;
        public DbSet<Profession> Profession { get; set; } = default!;
        public DbSet<Emp_Prof> Emp_Prof { get; set; } = default!;
        public DbSet<PhoneNumber> PhoneNumber { get; set; } = default!;

    }
}
