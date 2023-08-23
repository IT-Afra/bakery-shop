using BakeryAdmin.Infrastructure.Repositories;
using BakeryAdmin.Domain.Dtos;
using BakeryAdmin.Domain.IRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace BakeryAdmin.WebApi.Controllers
{
    [Authorize]
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
        [Authorize(Roles = "Admin")]
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
