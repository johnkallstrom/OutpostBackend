using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace OutpostBackend.Data
{
    public class OutpostDbContext : DbContext
    {
        public OutpostDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
