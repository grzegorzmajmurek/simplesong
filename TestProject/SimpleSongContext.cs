using Microsoft.EntityFrameworkCore;
using SimpleSong;
using SimpleSong.Model;

namespace TestProject
{
    public class SimpleSongContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=StoreDB;Trusted_Connection=True;");
        }
    }
}
