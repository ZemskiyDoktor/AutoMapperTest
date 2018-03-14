using AutoMapper;
using BusinessLayer.Dto;
using DataAccessLayer.Entities;

namespace BusinessLayer.Mapping
{
    public class FooEntityToBarDtoConverter : ITypeConverter<FooEntity, BarDto>
    {
        public BarDto Convert(FooEntity source, BarDto destination, ResolutionContext context)
        {
            return new BarDto
            {
                FullName = $"{source.FirstName} {source.SecondName}"
            };
        }
    }
}