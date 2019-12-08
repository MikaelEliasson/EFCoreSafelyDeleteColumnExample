using Microsoft.EntityFrameworkCore;

namespace EFCoreSafelyDeleteColumnExample
{
    public class Context : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlServer("Data Source=.\\;Initial Catalog=ef-removecolumn-test;Integrated Security=True");
    }
}
