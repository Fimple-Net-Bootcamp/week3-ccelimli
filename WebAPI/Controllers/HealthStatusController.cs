using Business.Abstracts;
using Entity.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/v1/healthstatus")]
    [ApiController]
    public class HealthStatusController : ControllerBase
    {
        IHealthService _healthService;

        public HealthStatusController(IHealthService healthService)
        {
            _healthService = healthService;
        }

        [HttpPost("add")]
        public IActionResult Add(AddHealthStatusRequest addHealthStatusRequest)
        {
            var Result = _healthService.Add(addHealthStatusRequest);
            if (Result.Success)
            {
                return Ok(Result);
            }
            return BadRequest(Result);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var result = _healthService.Delete(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var Result = _healthService.GetAll();
            if (Result.Success)
            {
                return Ok(Result);
            }
            return BadRequest(Result);
        }

        [HttpGet("getbyid/{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var Result = _healthService.GetById(id);
            if (Result.Success)
            {
                return Ok(Result);
            }
            return BadRequest(Result);
        }

        [HttpPut("update")]
        public IActionResult Update(UpdateHealthStatusRequest updateHealthStatusRequest)
        {
            var Result = _healthService.Update(updateHealthStatusRequest);
            if (Result.Success)
            {
                return Ok(Result);
            }
            return BadRequest(Result);
        }
    }
}

