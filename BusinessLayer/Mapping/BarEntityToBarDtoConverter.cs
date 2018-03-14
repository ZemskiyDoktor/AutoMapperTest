using AutoMapper;
using BusinessLayer.Dto;
using DataAccessLayer.Entities;

namespace BusinessLayer.Mapping
{
    public class BarEntityToBarDtoConverter : ITypeConverter<BarEntity, BarDto>
    {
        public BarDto Convert(BarEntity source, BarDto destination, ResolutionContext context)
        {
            return new BarDto
            {
                FullName = $"{source.FirstName} {source.SecondName}"
            };
        }
    }
}