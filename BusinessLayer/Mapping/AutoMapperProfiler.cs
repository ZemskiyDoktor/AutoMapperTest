using AutoMapper;
using BusinessLayer.Dto;
using DataAccessLayer.Entities;

namespace BusinessLayer.Mapping
{
    public class AutoMapperProfiler : Profile
    {
        public AutoMapperProfiler()
        {
            CreateMap<BarEntity, BarDto>().ConvertUsing<BarEntityToBarDtoConverter>();
            CreateMap<FooEntity, BarDto>().ConvertUsing<FooEntityToBarDtoConverter>();
            CreateMap<FooEntity, FooDto>().ConvertUsing<FooEntityToFooDtoConverter>();
            CreateMap<BarDto, FooEntity>().ConvertUsing<BarDtoToFooEntityConverter>();
            CreateMap<FooDto, FooEntity>().ConvertUsing<FooDtoToFooEntityConverter>();
        }
    }
}