using Microsoft.EntityFrameworkCore;
using Citadel.Domain.Entities;

namespace Citadel.DataAccess
{
    public class CitadelDbContext : DbContext, IDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "CitadelDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //SQL Table configuration code would normally go here

            //modelBuilder.ApplyConfiguration(new SomeConfigurationClass());
            //base.OnModelCreating(modelBuilder);
        }

        public DbSet<UserDetail> UserDetails
        {
            get;
            set;
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
