using Citadel.API.Models;
using Citadel.API.Validation;
using Xunit;

namespace Citadel.API.Tests.Validation
{
    [Trait("Category", "Unit")]
    public class UserDetailRequestValidatorTests
    {
        [Fact]
        public void Validate_WithCompleteRequest_Succeeds()
        {
            //Arrange
            var validator = new UserDetailRequestValidator();
            var request = Request;

            //Act
            var result = validator.Validate(request);

            //Assert
            Assert.True(result.IsValid);

        }

        [Fact]
        public void Validate_WithBlankRequest_Fails()
        {
            //Arrange
            var validator = new UserDetailRequestValidator();
            var request = new UserDetailRequest();

            //Act
            var result = validator.Validate(request);

            //Assert
            Assert.False(result.IsValid);

        }


        private UserDetailRequest Request => new()
        {
            Name = "John Gets the Job!"
        };

    }
}
