using Citadel.Domain.Entities;

namespace Citadel.Domain.Repositories
{
    public interface IUserDetailRepository 
    {
        Task AddAsync(UserDetail userDetail);
    }
}
