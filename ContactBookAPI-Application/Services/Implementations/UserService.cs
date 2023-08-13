using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ContactBookAPI_Application.Services.Interfaces;
using ContactBookAPI_Domain.Dtos.Requests;
using ContactBookAPI_Domain.Dtos.Responses;
using ContactBookAPI_Domain.Models;
using ContactBookAPI_Infrastructure.Uow;
using Microsoft.Extensions.Logging;

namespace ContactBookAPI_Application.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UserService> _logger;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork unitOfWork, ILogger<UserService> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<StandardResponse<UserResponseDto>> CreateUser(UserRequestDto userRequest)
        {
            if (userRequest == null)
            {
                _logger.LogError("user creation details cannot be null");
                return StandardResponse<UserResponseDto>.Failed("User request is null");
            }
            _logger.LogInformation("Attempting to create a user");
            var newUser = _mapper.Map<User>(userRequest);
            _logger.LogInformation($"User successfully created at: {DateTime.Now}");

            _unitOfWork.Users.Create(newUser);
            await _unitOfWork.SaveAync();
            _logger.LogInformation($"Company successfully saved to the database at: {DateTime.Now}");

            var userToReturn = _mapper.Map<UserResponseDto>(newUser);
            return StandardResponse<UserResponseDto>.Success($"Company successfully created a company {userRequest.FullName}", userToReturn, 201);
        }

        public Task<StandardResponse<UserResponseDto>> DeleteUser(UserRequestDto userRequest)
        {
            throw new NotImplementedException();
        }

        public Task<StandardResponse<UserResponseDto>> EditPhoto(UserRequestDto userRequest)
        {
            throw new NotImplementedException();
        }

        public Task<StandardResponse<UserResponseDto>> UpdateUser(UserRequestDto userRequest)
        {
            throw new NotImplementedException();
        }
    }
}
