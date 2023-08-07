using Citadel.Domain.Entities;
using Citadel.Domain.Repositories;


namespace Citadel.DataAccess.Repositories
{
    public class UserDetailRepository : IUserDetailRepository
    {
        public readonly IDbContext Context;

        public UserDetailRepository(IDbContext context)
        {
            Context = context;
        }

        public async Task AddAsync(UserDetail userDetail)
        {
            await Context.Set<UserDetail>().AddAsync(userDetail);
        }
    }
}
