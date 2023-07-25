using Bakeryshop.Domain.Dtos;
using Bakeryshop.Domain.IRepositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bakeryshop.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpGet]
        [Route("{userId:long}")]
        public ActionResult<List<OrderDto>> Get(long userId)
        {
            return Ok(_orderRepository.GetAll(userId));
        }

        [HttpPost]
        [Route("{userId:long}")]
        public ActionResult<OrderDto> Save(long userId, OrderDto objDto)
        {
            return Ok(_orderRepository.Save(userId, objDto));
        }

        [HttpDelete]
        [Route("{userId:long}/{id:long}")]
        public IActionResult Delete( long userId, long id)
        {
            _orderRepository.Delete(userId, id);
            return Ok();
        }
    }
}
