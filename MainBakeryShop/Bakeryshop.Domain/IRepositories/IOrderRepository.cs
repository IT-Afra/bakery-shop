using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bakeryshop.Domain.Dtos;

namespace Bakeryshop.Domain.IRepositories
{
    public interface IOrderRepository
    {
        //public List<DeliveryDto> GetAllReserve();
        //public long NewReserve(long UserId, long SchaduleID , OrderDto orderDto);
        //public void ReserveCancel(long UserId);



        public List<OrderDto> GetAll(long UserId);
        public OrderDto Save(long UserId, OrderDto objDto);
        public void Delete(long UserId, long id);
    }
}
