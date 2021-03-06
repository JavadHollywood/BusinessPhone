using System.Linq;
using AutoMapper;
using BusinessPhone.Dtos;
using BusinessPhone.Models;

namespace BusinessPhone.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForDetailedDto>()
            .ForMember(dest => dest.PhotoUrl, opt =>
            {
                opt.MapFrom(src => src.Photos.FirstOrDefault(f => f.IsMain).Url);
            })
            .ForMember(dest => dest.Age, opt =>
            {
                opt.MapFrom(d => d.DateOfBirth.CalculateAge());

            });

            CreateMap<User, UserForListDto>()
            .ForMember(dest => dest.PhotoUrl, opt =>
            {
                opt.MapFrom(src => src.Photos.FirstOrDefault(f => f.IsMain).Url);
            })
            .ForMember(dest => dest.Age, opt =>
            {
                opt.MapFrom(d => d.DateOfBirth.CalculateAge());

            });

            CreateMap<Photo, PhotosForDetailedDto>();
            CreateMap<UserForRegisterDto,User>();
             CreateMap<User,UserForRegisterDto>();
        }
    }
}