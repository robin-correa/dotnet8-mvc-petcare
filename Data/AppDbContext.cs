using dotnet8_mvc_petcare.Models.Domains;

using Microsoft.EntityFrameworkCore;

namespace dotnet8_mvc_petcare.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Service> Services { get; set; }
    }
}
