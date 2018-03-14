using AutoMapper;
using BusinessLayer.Dto;
using DataAccessLayer.Entities;

namespace BusinessLayer.Mapping
{
    public static partial class MapHelper
    {
        public static class MakeBarDto
        {
            public static void FromBarEntity(IMapperConfigurationExpression cnf)
            {
                cnf.CreateMap<BarEntity, BarDto>()
                    .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.SecondName}"));
            }

            public static void FromFooEntity(IMapperConfigurationExpression cnf)
            {
                cnf.CreateMap<FooEntity, BarDto>()
                    .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.SecondName}"));
            }
        }
    }
}