using BakeryAdmin.Domain.Dtos;
using BakeryAdmin.Domain.IRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BakeryAdmin.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationRepository _authenticationRepository;

        public AuthenticationController(IAuthenticationRepository authenticationRepository)
        {
            _authenticationRepository = authenticationRepository;
        }

        [HttpPost]
        [Route("Login")]
        public ActionResult<AuthResultDto> Login(LoginDto model)
        {
            return Ok(_authenticationRepository.Login(model));
        }

    }
}
