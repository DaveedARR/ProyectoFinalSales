using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sales.Infrastructure.Gateway.Identity;

namespace Sales.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IdentityService _identityService;

        public LoginController(IdentityService identityService)
        {
            _identityService = identityService;
        }

        [HttpPost("Login")]
        public async Task<ActionResult> Login(Request request)
        {
            var result = await _identityService.PostRequestAsync(request);
            return Ok(result);
        }
    }
}
