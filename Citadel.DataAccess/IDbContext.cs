using Microsoft.EntityFrameworkCore;

namespace Citadel.DataAccess
{
    public interface IDbContext : IDisposable
    {
        Task<int> SaveChangesAsync();
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}
