using Microsoft.EntityFrameworkCore;
using LibraryManagement.Domain.Entities; 

namespace LibraryManagement.Domain.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }

        public DbSet<Books> Books { get; set; }
        public DbSet<Members> Members { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
     
            modelBuilder.Entity<Books>()
                .Property(b => b.Title)
                .HasMaxLength(100)
                .IsRequired(); 

            modelBuilder.Entity<Members>()
                .Property(m => m.Name)
                .HasMaxLength(100)
                .IsRequired(); 

            modelBuilder.Entity<Members>()
                .Property(m => m.Email)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
