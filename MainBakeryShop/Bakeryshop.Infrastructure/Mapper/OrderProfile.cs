using AutoMapper;
using Bakeryshop.Domain.Dtos;
using Bakeryshop.Framework;
using Bakeryshop.Infrastructure.EntityFramework.Entities;

namespace Bakeryshop.Infrastructure.Mapper
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<bksOrder, OrderDto>()
                .ForMember(d => d.SchaduleDate, opt => opt.MapFrom(s => s.Schadule.SchaduleDate))
                .ForMember(d => d.SchaduleTime, opt => opt.MapFrom(s => s.Schadule.SchaduleTime));

            CreateMap<OrderDto, bksOrder>()
                .ForMember(d => d.RegisterDateTimeL, opt => opt.MapFrom(s => s.RegisterDateTime!.ToDateTimeLong()))
                .ForMember(d => d.DeliveryDateTimeL, opt => opt.MapFrom(s => s.DeliveryDateTime == null ? (long?)null : s.DeliveryDateTime!.ToDateTimeLong()))
                .ForMember(d => d.TotalPrice, opt => opt.MapFrom(s => s.OrderDetails.Sum(a => a.Amount *  a.Price)));

            CreateMap<bksOrderDetail, OrderDetailDto>();

            CreateMap<OrderDetailDto, bksOrderDetail>();
        }
    }
}
