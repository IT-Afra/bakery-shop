using Bakeryshop.Domain.Dtos;
using Bakeryshop.Domain.IRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bakeryshop.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchaduleController : ControllerBase
    {
        private readonly ISchaduleRepository _schaduleRepository;

        public SchaduleController(ISchaduleRepository schaduleRepository)
        {
            _schaduleRepository = schaduleRepository;
        }
        [HttpGet]
        public ActionResult<List<SchaduleDto>> GetAll()
        {
            return Ok(_schaduleRepository.GetAll());
        }

        [HttpGet]
        public ActionResult<List<SchaduleDto>> GetSchaduleByDate(string dateTime)
        {
            return Ok(_schaduleRepository.GetSchaduleByDate(dateTime));
        }


        [HttpPost]
        public ActionResult<SchaduleDto> Save([FromBody] SchaduleDto objDto)
        {
            return Ok(_schaduleRepository.Save(objDto));
        }

        [HttpDelete]
        [Route("{id:long}")]
        public IActionResult Delete(long id)
        {
            _schaduleRepository.Delete(id);
            return Ok();
        }
    }
}
