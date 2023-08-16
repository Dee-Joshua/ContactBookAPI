using ContactBookAPI_Application.Services.Interfaces;
using ContactBookAPI_Domain.Dtos.Requests;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContactBookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        // GET: api/<AuthenticationController>

        private IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }



        // POST api/<AuthenticationController>
        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] UserRequestDto requestDto)
        {
            var result = await _authenticationService.RegisterUser(requestDto);
            if(!result.Succeeded)
            {
                foreach(var error  in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }
            return StatusCode(201);
        }

        // POST api/<AuthenticationController>
        [HttpPost("login")]
        public async Task<IActionResult> LoginUser([FromBody] UserLoginDto requestDto)
        {
            if (!await _authenticationService.ValidateUser(requestDto))
            {
                return Unauthorized();
            }
            return Ok(new { token = await _authenticationService.CreateToken() });
        }

    }
}
