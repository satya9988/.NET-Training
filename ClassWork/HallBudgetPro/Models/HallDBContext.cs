using Microsoft.EntityFrameworkCore;

namespace HallBudgetPro.Models
{
    public class HallDBContext : DbContext
    {
        public HallDBContext(DbContextOptions<HallDBContext> options) : base(options)
        {
        }

        public DbSet<Hall> Hall { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hall>().ToTable("hall");
        }
    }
}
