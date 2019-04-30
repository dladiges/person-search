using Microsoft.EntityFrameworkCore;

namespace PersonData
{
    public class SearchContext : DbContext
    {
        public SearchContext(DbContextOptions<SearchContext> options) : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Interest> Interests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<Interest>().ToTable("Interest");
        }
    }
}