using Microsoft.EntityFrameworkCore;
using Random_Forest.Models;

namespace Random_Forest.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Holder> Holders { get; set; }
    }
}