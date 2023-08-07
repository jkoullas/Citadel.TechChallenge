using Citadel.API.Models;
using Citadel.Domain.Entities;

namespace Citadel.API.Mappers
{
    public interface IUserDetailMapper : IMapper<UserDetailRequest, UserDetail>
    {
    }

    public class UserDetailMapper : IUserDetailMapper
    {
        public UserDetail Map(UserDetailRequest userDetailRequest)
        {
            return new UserDetail()
            {
                Name = userDetailRequest.Name,
            };

        }

    }
}
