using Api_DnD.Model;
using Microsoft.EntityFrameworkCore;

namespace Api_DnD.Data
{
    public class KeyContext : DbContext
    {

        public KeyContext(DbContextOptions<DNDContext> options) : base(options)
        {
        }

        public DbSet<Key> key { get; set; }
        
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Key>().ToTable("Key");
        }
    }
}
