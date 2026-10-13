
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Contexts
{
    public class BookstoreDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                "Server=.;Database=BookstoreDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(b => b.Title)
                      .IsRequired()
                      .HasMaxLength(150);

                entity.Property(b => b.Price)
                      .HasColumnType("decimal(8,2)");

                entity.Property(b => b.PublishedDate)
                      .IsRequired(false);
            });
        }

    }
}
