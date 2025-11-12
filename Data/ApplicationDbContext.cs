using Microsoft.EntityFrameworkCore;

namespace Random_Forest.Data;

public class ApplicationDbContext: DbContext
{
        public ApplicationDbContext(DbContextOptions<DbContext> options) : base(options) { }
}