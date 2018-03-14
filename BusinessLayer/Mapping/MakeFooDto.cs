using AutoMapper;
using BusinessLayer.Dto;
using DataAccessLayer.Entities;

namespace BusinessLayer.Mapping
{
    public static partial class MapHelper
    {
        public static class MakeFooDto
        {
            public static void FromFooEntity(IMapperConfigurationExpression cnf)
            {
                cnf.CreateMap<FooEntity, FooDto>()
                    .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.SecondName}"));
            }
        }
    }
}