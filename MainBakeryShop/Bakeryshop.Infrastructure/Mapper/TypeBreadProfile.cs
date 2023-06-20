using AutoMapper;
using Bakeryshop.Domain.Dtos;
using Bakeryshop.Infrastructure.EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bakeryshop.Infrastructure.Mapper
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
