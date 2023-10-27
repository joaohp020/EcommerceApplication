using EcommerceApplication.Service.Contracts;
using EcommerceApplication.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApplication.API.Controllers
{
    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController : Controller
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost]
        public async Task<IActionResult> Index(AuthenticationModel authentication)
        {
            try
            {
                authentication.Validate();
                var user = await _authenticationService.Authenticate(authentication.identifierUser, authentication.pass, authentication.idCompany);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
