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
        public List<OrderDto> GetAll();
        public void Update(OrderDto objDto);
        public void Save(OrderDto objDto);
        public void Delete(long id);
    }
}
