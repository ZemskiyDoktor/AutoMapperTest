using System;
using AutoMapper;
using BusinessLayer.Dto;
using BusinessLayer.Mapping;
using DataAccessLayer.Entities;

namespace AutoMapperTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //First version
            //AutoMapper.Mapper.Initialize(cfg =>
            //{
            //    MapHelper.MakeBarDto.FromBarEntity(cfg);
            //    MapHelper.MakeBarDto.FromFooEntity(cfg);
            //    MapHelper.MakeFooDto.FromFooEntity(cfg);
            //    MapHelper.MakeFooEntity.FromBarDto(cfg);
            //    MapHelper.MakeFooEntity.FromFooDto(cfg);
            //});

            //Second version
            //AutoMapper.Mapper.Initialize(cfg =>
            //{
            //    cfg.CreateMap<BarEntity, BarDto>().ConvertUsing<BarEntityToBarDtoConverter>();
            //    cfg.CreateMap<FooEntity, BarDto>().ConvertUsing<FooEntityToBarDtoConverter>();
            //    cfg.CreateMap<FooEntity, FooDto>().ConvertUsing<FooEntityToFooDtoConverter>();
            //    cfg.CreateMap<BarDto, FooEntity>().ConvertUsing<BarDtoToFooEntityConverter>();
            //    cfg.CreateMap<FooDto, FooEntity>().ConvertUsing<FooDtoToFooEntityConverter>();
            //});

            //Third version
            //AutoMapper.Mapper.Initialize(cfg => cfg.AddProfile<AutoMapperProfiler>());

            //Fourth vertion (for DI)
            IMapper mapper = MapperConfig.InitializeAutoMapper().CreateMapper();

            Run(mapper);
        }

        private static void Run(IMapper mapper)
        {
            

            var fooEntity = new FooEntity {FirstName = "John", SecondName = "Foo"};
            var barEntity = new BarEntity {FirstName = "John", SecondName = "Bar"};

            var dto1 = mapper.Map<BarDto>(fooEntity);
            var dto2 = mapper.Map<BarDto>(barEntity);
            var dto3 = mapper.Map<FooDto>(fooEntity);

            var entity2 = mapper.Map<FooEntity>(dto2);
            var entity3 = mapper.Map<FooEntity>(dto3);

            Console.WriteLine($"From FooEntity {dto1.FullName}");
            Console.WriteLine($"From BarEntity {dto2.FullName}");
            Console.WriteLine($"From FooEntity {dto3.FullName}");

            Console.WriteLine($"From BarDto {entity2.FirstName} {entity2.SecondName}");
            Console.WriteLine($"From FooDto {entity3.FirstName} {entity3.SecondName}");
        }
    }
}
