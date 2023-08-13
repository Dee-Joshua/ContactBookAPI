using ContactBookAPI_Domain.Dtos.Requests;
using ContactBookAPI_Domain.Dtos.Responses;

namespace ContactBookAPI_Application.Services.Interfaces
{
    public interface IUserService
    {
        Task<StandardResponse<UserResponseDto>> CreateUser(UserRequestDto userRequest);
        Task<StandardResponse<UserResponseDto>> UpdateUser(UserRequestDto userRequest);
        Task<StandardResponse<UserResponseDto>> DeleteUser(UserRequestDto userRequest);
        Task<StandardResponse<UserResponseDto>> EditPhoto(UserRequestDto userRequest);
    }
}