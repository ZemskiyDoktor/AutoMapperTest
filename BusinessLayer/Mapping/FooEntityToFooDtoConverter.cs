using AutoMapper;
using BusinessLayer.Dto;
using DataAccessLayer.Entities;

namespace BusinessLayer.Mapping
{
    public class FooEntityToFooDtoConverter : ITypeConverter<FooEntity, FooDto>
    {
        public FooDto Convert(FooEntity source, FooDto destination, ResolutionContext context)
        {
            return new FooDto
            {
                FullName = $"{source.FirstName} {source.SecondName}"
            };
        }
    }
}