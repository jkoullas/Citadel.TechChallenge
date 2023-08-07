using Citadel.Domain.Entities;
using Citadel.Domain.Repositories;

namespace Citadel.Core.Services
{
    public interface IUserDetailService
    {
        Task AddAsync(UserDetail userDetail);
    }

    public class UserDetailService : IUserDetailService
    {
        private readonly IUserDetailRepository _userDetailRepository;

        public UserDetailService(IUserDetailRepository userDetailRepository)
        {
            _userDetailRepository = userDetailRepository;
        }

        public async Task AddAsync(UserDetail userDetail)
        {
            userDetail.Id = Guid.NewGuid(); //Just for the demo, assign random Id
            await _userDetailRepository.AddAsync(userDetail);
        }
    }
}