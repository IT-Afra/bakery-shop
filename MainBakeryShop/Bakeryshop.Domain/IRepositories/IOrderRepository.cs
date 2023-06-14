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
        public List<DeliveryDto> GetAllReserve();
        public List<OrderDto> NewReserve(long UserId, long SchaduleID);
        public void ReserveCancel(long UserId);
    }
}
