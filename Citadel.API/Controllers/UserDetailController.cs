using Citadel.API.Mappers;
using Citadel.API.Models;
using Citadel.Core.Services;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace Citadel.API.Controllers
{
    [Route("api/user-detail")]
    [ApiController]
    public class UserDetailController : Controller
    {
        private readonly IUserDetailService _userDetailService;
        private readonly IUserDetailMapper _userDetailMapper;
        private readonly IValidator<UserDetailRequest> _validator;
        private readonly ILogger<UserDetailController> _logger;

        public UserDetailController(
            IUserDetailService userDetailService,
            IUserDetailMapper userDetailMapper,
            IValidator<UserDetailRequest> validator,
            ILogger<UserDetailController> logger)
        {
            _userDetailService = userDetailService;
            _userDetailMapper = userDetailMapper;
            _validator = validator;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Post(UserDetailRequest userDetailRequest)
        {
            _logger.LogInformation($"Received request from '{userDetailRequest.Name}'");

            //Validate the userDetailRequest. If validation fails, return 400.
            var validationResult = await _validator.ValidateAsync(userDetailRequest);
            if (!validationResult.IsValid)
            {
                _logger.LogInformation($"Validation failed for '{userDetailRequest.Name}'");
                return new BadRequestObjectResult(validationResult);
            }

            var userDetail = _userDetailMapper.Map(userDetailRequest);

            await _userDetailService.AddAsync(userDetail);

            // Return success with message
            return new OkObjectResult($"Thank you {userDetailRequest.Name}");
        }
    }
}
