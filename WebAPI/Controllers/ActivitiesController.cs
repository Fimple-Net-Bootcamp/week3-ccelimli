using Business.Abstracts;
using Entity.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/v1/activities")]
    [ApiController]
    public class ActivitiesController : ControllerBase
    {
        IActivityService _activityService;

        public ActivitiesController(IActivityService activityService)
        {
            _activityService = activityService;
        }

        [HttpPost("add")]
        public IActionResult Add(AddActiviteRequest addActiviteRequest)
        {
            var Result=_activityService.Add(addActiviteRequest);
            if (Result.Success) {
                return Ok(Result);
            }
            return BadRequest(Result);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var result= _activityService.Delete(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll() {
            var Result=_activityService.GetAll();
            if (Result.Success)
            {
                return Ok(Result);
            }
            return BadRequest(Result);
        }

        [HttpGet("getbyid/{id}")]
        public IActionResult Get([FromRoute]int id) {
            var Result=_activityService.GetById(id);
            if (Result.Success)
            {
                return Ok(Result);
            }
            return BadRequest(Result);
        }

        [HttpPut("update")]
        public IActionResult Update(UpdateActiviyRequest updateActiviyRequest)
        {
            var Result = _activityService.Update(updateActiviyRequest);
            if (Result.Success) {
                return Ok(Result);   
            }
            return BadRequest(Result);
        }

        [HttpGet("getalldetails")]
        public IActionResult GetAllDetails()
        {
            var Result = _activityService.GetAllDetail();
            if (Result.Success)
            {
                return Ok(Result);
            }
            return BadRequest(Result);
        }
    }
}
