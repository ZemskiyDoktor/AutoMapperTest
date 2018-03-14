using AutoMapper;
using BusinessLayer.Dto;
using DataAccessLayer.Entities;

namespace BusinessLayer.Mapping
{
    public static partial class MapHelper
    {
        public static class MakeFooEntity
        {
            public static void FromFooDto(IMapperConfigurationExpression cfg)
            {
                cfg.CreateMap<FooDto, FooEntity>()
                    .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FullName.Split(' ')[0]))
                    .ForMember(dest => dest.SecondName, opt => opt.MapFrom(src => src.FullName.Split(' ')[1]));
            }

            public static void FromBarDto(IMapperConfigurationExpression cfg)
            {
                cfg.CreateMap<BarDto, FooEntity>()
                    .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FullName.Split(' ')[0]))
                    .ForMember(dest => dest.SecondName, opt => opt.MapFrom(src => src.FullName.Split(' ')[1]));
            }
        }
    }
}