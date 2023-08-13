using AutoMapper;
using ContactBookAPI_Domain.Dtos.Requests;
using ContactBookAPI_Domain.Dtos.Responses;
using ContactBookAPI_Domain.Models;

namespace ContactBookAPI_Application.Commons
{
    public class MapInitializers : Profile
    {
        public MapInitializers()
        {
            CreateMap<UserRequestDto, User>();
            CreateMap<User, UserResponseDto>();

            CreateMap<ContactRequestDto, Contact>();
            CreateMap<Contact, ContactResponseDto>();
        }
    }
}
