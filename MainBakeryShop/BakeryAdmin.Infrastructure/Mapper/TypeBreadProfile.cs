using AutoMapper;
using BakeryAdmin.Domain.Dtos;
using Bakeryshop.Infrastructure.EntityFramework.Entities;

namespace BakeryAdmin.Infrastructure.Mapper
{
    public class TypeBreadProfile : Profile
    {
        public TypeBreadProfile()
        {
            CreateMap<bksTypeBread, TypeBreadDto>();
            CreateMap<TypeBreadDto, bksTypeBread>();
        }
    }
}
