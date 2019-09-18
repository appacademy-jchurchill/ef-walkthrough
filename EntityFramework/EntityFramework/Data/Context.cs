using EntityFramework.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EntityFramework.Data
{
    public class Context : DbContext
    {
        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Person>()
                .Property(p => p.Weight).HasPrecision(5, 2);
        }
    }
}
