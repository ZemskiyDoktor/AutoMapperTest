using AutoMapper;
using BusinessLayer.Dto;
using DataAccessLayer.Entities;

namespace BusinessLayer.Mapping
{
    public class BarDtoToFooEntityConverter : ITypeConverter<BarDto, FooEntity>
    {
        public FooEntity Convert(BarDto source, FooEntity destination, ResolutionContext context)
        {
            return new FooEntity
            {
                FirstName = source.FullName.Split(' ')[0],
                SecondName = source.FullName.Split(' ')[1]
            };
        }
    }
}