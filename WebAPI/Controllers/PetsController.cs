using Business.Abstracts;
using Entity.Concretes;
using Entity.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/v1/pets")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        IPetService _petService;

        public PetsController(IPetService petService)
        {
            _petService = petService;
        }

        [HttpPost("add")]
        public IActionResult Add(AddPetRequest addPetRequest)
        {
            var Result = _petService.Add(addPetRequest);
            if (Result.Success)
            {
                return Ok(Result);
            }
            return BadRequest(Result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var Result = _petService.GetAll();
            if (Result.Success)
            {
                return Ok(Result);
            }
            return BadRequest(Result);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {

            var Result = _petService.Delete(id);
            if (Result.Success)
            {
                return Ok(Result);
            }
            return BadRequest(Result);
        }

        [HttpGet("getbyid/{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var Result= _petService.GetById(id);
            if (Result.Success)
            {
                return Ok(Result);
            }
            return BadRequest(Result);
        }

        [HttpGet("getallpetdetails")]
        public IActionResult GetAllPetDetails()
        {
            var Result = _petService.GetAllPetDetails();
            if (Result.Success) {
                return Ok(Result);
            }
            return BadRequest(Result);
        }

        [HttpPut("update")]
        public IActionResult Update(UpdatePetRequest updatePetRequest)
        {
            var Result= _petService.Update(updatePetRequest);
            if (Result.Success)
            {
                return Ok(Result);
            }
            return BadRequest(Result);
        }
    }
}
