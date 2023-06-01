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
        private ITypeBreadRepository typeBreadRepository { get; set; }

        public TypeBreadController()
        {
            typeBreadRepository = new TypeBreadRepository();
        }

        [HttpGet]
        public ActionResult<List<TypeBreadDto>> Get() 
        {
            return Ok(typeBreadRepository.GetAll());
        }

    }
}
