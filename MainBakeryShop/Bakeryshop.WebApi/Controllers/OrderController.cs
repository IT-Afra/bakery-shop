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
        [Route("{UserId:long}")]
        public ActionResult<List<OrderDto>> Get(long UserId)
        {
            return Ok(_orderRepository.GetAll(UserId));
        }

        [HttpDelete]
        [Route("{UserId:long}/{id:long}")]
        public IActionResult Delete(long UserId, long id)
        {
            _orderRepository.Delete(UserId, id);
            return Ok();
        }
    }
}
