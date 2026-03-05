using Microsoft.EntityFrameworkCore;

namespace AiModelRegistry.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options) { }

        public DbSet<AiModel> AiModels { get; set; }
    }
}
