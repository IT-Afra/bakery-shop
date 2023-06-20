using AutoMapper;
using Bakeryshop.Domain.Dtos;
using Bakeryshop.Framework;
using Bakeryshop.Infrastructure.EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakeryshop.Infrastructure.Mapper
{
    public class SchaduleProfile : Profile
    {
        public SchaduleProfile()
        {

            CreateMap<bksSchadule, SchaduleDto>();


            CreateMap<SchaduleDto, bksSchadule>()
                .ForMember(d=>d.SchaduleDateL, opt => opt.MapFrom(s => s.SchaduleDate == null ? (long?)null : s.SchaduleDate!.ToDateTimeLong()))
                .ForMember(d => d.SchaduleTimeL, opt => opt.MapFrom(s => s.SchaduleTime == null ? (long?)null : s.SchaduleTime!.ToDateTimeLong()));


            CreateMap<bksSchaduleDetail, SchaduleDetailDto>();

            CreateMap<SchaduleDetailDto, bksSchaduleDetail>();
        }
    }
}
