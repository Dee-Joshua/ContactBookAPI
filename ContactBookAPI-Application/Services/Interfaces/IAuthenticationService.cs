using ContactBookAPI_Domain.Dtos.Requests;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBookAPI_Application.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<IdentityResult> RegisterUser(UserRequestDto userRequest);
        Task<bool> ValidateUser(UserLoginDto userLoginDto);
        Task<string> CreateToken(); 
    }
}
