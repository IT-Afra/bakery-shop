﻿using AutoMapper;
using Bakeryshop.Domain.Dtos;
using Bakeryshop.Framework;
using Bakeryshop.Infrastructure.EntityFramework.Entities;

namespace Bakeryshop.Infrastructure.Mapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
     {
            CreateMap<gtUser, UserDto>();

            CreateMap<UserDto, gtUser>();
        }
    }
}
