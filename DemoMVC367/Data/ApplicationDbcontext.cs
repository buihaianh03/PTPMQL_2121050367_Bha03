using Microsoft.EntityFrameworkCore;
using DemoMVC367.Models;

namespace DemoMVC367.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
    }
}
