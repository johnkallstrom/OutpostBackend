using Microsoft.EntityFrameworkCore;
using OutpostBackend.Core.Entities;
using System.Reflection;

namespace OutpostBackend.Data
{
    public class OutpostDbContext : DbContext
    {
        public OutpostDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; } = default!;
        public DbSet<Post> Posts { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
