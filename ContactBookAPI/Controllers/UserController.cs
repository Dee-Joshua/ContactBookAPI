using ContactBookAPI_Application.Services.Interfaces;
using ContactBookAPI_Domain.Dtos.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactBookAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("add-new")]
        public async Task<IActionResult> CreateUser([FromBody]UserRequestDto userRequestDto)
        {
            var response = await _userService.CreateUser(userRequestDto);
            return Ok(response);
        }

        /*[HttpPut]
        [Route("update/[id]")]
        public async Task<IActionResult> UpdateUser([FromBody]UserRequestDto userRequestDto)
        {
            var response = await _userService.UpdateUser(userRequestDto);
            return Ok(response);
        }

        [HttpDelete]
        [Route("delete/[id]")]
        public async Task<IActionResult> DeleteUser([FromBody] UserRequestDto userRequestDto)
        {
            var response = await _userService.DeleteUser(userRequestDto);
            return Ok(response);
        }

        [HttpPatch]
        [Route("photo/[id]")]
        public async Task<IActionResult> EditPhoto([FromBody] UserRequestDto userRequestDto)
        {
            var response = await _userService.EditPhoto(userRequestDto);
            return Ok(response);
        }*/
    }
}
