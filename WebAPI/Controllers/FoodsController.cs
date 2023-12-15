using Business.Abstracts;
using Entity.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/v1/foods")]
    [ApiController]
    public class FoodsController : ControllerBase
    {

        IFoodService _foodService;

        public FoodsController(IFoodService foodService)
        {
            _foodService = foodService;
        }

        [HttpPost("add")]
        public IActionResult Add(AddFoodRequest addFoodRequest)
        {
            var Result = _foodService.Add(addFoodRequest);
            if (Result.Success)
            {
                return Ok(Result);
            }
            return BadRequest(Result);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var result = _foodService.Delete(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var Result = _foodService.GetAll();
            if (Result.Success)
            {
                return Ok(Result);
            }
            return BadRequest(Result);
        }

        [HttpGet("getbyid/{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var Result = _foodService.GetById(id);
            if (Result.Success)
            {
                return Ok(Result);
            }
            return BadRequest(Result);
        }

        [HttpPut("update")]
        public IActionResult Update(UpdateFoodRequest updateFoodRequest)
        {
            var Result = _foodService.Update(updateFoodRequest);
            if (Result.Success)
            {
                return Ok(Result);
            }
            return BadRequest(Result);
        }

        [HttpGet("getalldetails")]
        public IActionResult GetAllDetails()
        {
            var Result = _foodService.GetFoodDetails();
            if (Result.Success)
            {
                return Ok(Result);
            }
            return BadRequest(Result);
        }
    }
}
