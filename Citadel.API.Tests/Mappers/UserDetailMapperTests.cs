using Citadel.API.Mappers;
using Citadel.API.Models;
using Xunit;

namespace Citadel.API.Tests.Mappers
{
    [Trait("Category", "Unit")]
    public class UserDetailMapperTests
    {
        [Fact]
        public void Map_Succeeds()
        {
            //Arrange
            var request = new UserDetailRequest()
            {
                Name = "John Gets the Job!"
            };

            var mapper = new UserDetailMapper();

            //Act
            var result = mapper.Map(request);

            //Assert
            Assert.Equal(request.Name, result.Name);

        }
    }
}