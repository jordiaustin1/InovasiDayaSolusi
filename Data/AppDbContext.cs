using Microsoft.EntityFrameworkCore;
using ViewDataApi.Models;

namespace ViewDataApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts) { }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>().ToTable("transactions").HasKey(t => t.Id);
            modelBuilder.Entity<Status>().ToTable("statuses").HasKey(s => s.Id);
        }
    }
}
