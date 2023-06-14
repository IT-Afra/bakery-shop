using AutoMapper;
using Bakeryshop.Domain.Dtos;
using Bakeryshop.Domain.IRepositories;
using Bakeryshop.Infrastructure.EntityFramework;
using Bakeryshop.Infrastructure.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bakeryshop.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly BakeryshopContext _dbContext;
        private readonly IMapper _mapper;

        public OrderRepository(BakeryshopContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }


        public List<OrderDto> GetAll(long UserId)
        {
            return _mapper.Map<List<OrderDto>>(
                _dbContext.bksOrders
                    .Include(a => a.Schadule)
                    .Include(a => a.OrderDetails)
                        .Where(a => a.UserId == UserId));
        }

        public void Delete(long UserId, long id)
        {
            throw new NotImplementedException();
        }


        public OrderDto Save(long UserId, OrderDto objDto)
        {
            var order = _mapper.Map<bksOrder>(objDto);
            order.UserId = UserId;  
            if (order.Id == 0)
            {
                _dbContext.bksOrders.Add(order);
            }
            else
            {
                _dbContext.bksOrders.Update(order);
            }
            _dbContext.SaveChanges();

            return _mapper.Map<OrderDto>(_dbContext.bksOrders
                    .Include(a => a.Schadule)
                    .Include(a => a.OrderDetails)
                        .Where(a => a.Id == order.Id));
        }
    }
}
