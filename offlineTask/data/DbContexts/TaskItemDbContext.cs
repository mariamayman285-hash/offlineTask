using Microsoft.EntityFrameworkCore;
using offlineTask.Models;
namespace offlineTask.data.DbContexts

{
    public class TaskItemDbContext : DbContext
    {
        public DbSet<Taskitem> Taskitems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=OfflineTaskSystem;Integrated Security=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Taskitem>()
                        .ToTable("TaskItems")
                        .HasKey(t => t.Id);

            modelBuilder.Entity<Taskitem>()
                        .Property(x => x.Title)
                        .HasMaxLength(100);

            modelBuilder.Entity<Taskitem>()
                        .Property(p => p.Description)
                        .HasMaxLength(500);

            modelBuilder.Entity<Taskitem>()
                        .Property(x => x.CreatedAt)
                        .HasDefaultValue(DateTime.UtcNow);

        }
    }
}
