using System;
using AutoMapper;
using tetaix_circuit.Dtos;
using tetaix_circuit.Modele;

namespace tetaix_circuit.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserSignUpDto, User>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Email));
        }
    }
}
