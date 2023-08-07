using Citadel.Core.Services;
using Citadel.Domain.Entities;
using Citadel.Domain.Repositories;
using Moq;
using Xunit;

namespace Citadel.Core.Tests.Services
{
    [Trait("Category", "Unit")]
    public class UserDetailServiceTests
    {
        private readonly Mock<IUserDetailRepository> _integrationEventRepository;

        public UserDetailServiceTests()
        {
            _integrationEventRepository = new Mock<IUserDetailRepository>();
        }


        [Fact]
        public async Task Add_Success()
        {
            //Arrange

            var service = new UserDetailService(_integrationEventRepository.Object);

            //Act
            await service.AddAsync(new UserDetail());

            //Assert
            _integrationEventRepository.Verify(d => d.AddAsync(It.IsAny<UserDetail>()), Times.Once);

        }



    }
}