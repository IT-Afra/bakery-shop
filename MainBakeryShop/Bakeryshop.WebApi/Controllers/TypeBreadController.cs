using Bakeryshop.Infrastructure.Repositories;
using Bakeryshop.Domain.Dtos;
using Bakeryshop.Domain.IRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bakershop.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeBreadController : ControllerBase
    {
        private readonly ITypeBreadRepository _typeBreadRepository;

        public TypeBreadController(ITypeBreadRepository typeBreadRepository)
        {
            _typeBreadRepository = typeBreadRepository;
        }

        [HttpGet]
        public ActionResult<List<TypeBreadDto>> Get() 
        {
            return Ok(_typeBreadRepository.GetAll());
        }

        [HttpPost]
        public ActionResult<List<TypeBreadDto>> Save([FromBody]TypeBreadDto objDto)
        {
            return Ok(_typeBreadRepository.Save(objDto));
        }

        [HttpDelete]
        [Route("{id:long}")]
        public IActionResult Delete(long id)
        {
            _typeBreadRepository.Delete(id);
            return Ok(); 
        }
    }
}
