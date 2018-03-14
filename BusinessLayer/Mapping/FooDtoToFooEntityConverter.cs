using AutoMapper;
using BusinessLayer.Dto;
using DataAccessLayer.Entities;

namespace BusinessLayer.Mapping
{
    public class FooDtoToFooEntityConverter : ITypeConverter<FooDto, FooEntity>
    {
        public FooEntity Convert(FooDto source, FooEntity destination, ResolutionContext context)
        {
            return new FooEntity
            {
                FirstName = source.FullName.Split(' ')[0],
                SecondName = source.FullName.Split(' ')[1]
            };
        }
    }
}