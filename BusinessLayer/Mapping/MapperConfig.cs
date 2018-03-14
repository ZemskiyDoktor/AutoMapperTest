using AutoMapper;
using AutoMapper.Configuration.Conventions;
using BusinessLayer.Dto;
using DataAccessLayer.Entities;

namespace BusinessLayer.Mapping
{
    public static class MapperConfig
    {
        public static MapperConfiguration InitializeAutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfiler>();
            });

            return config;
        }
    }
}
