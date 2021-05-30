using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarotImagesController : ControllerBase
    {
        ITarotImageService _tarotImageService;
        public TarotImagesController(ITarotImageService tarotImageService)
        {
            _tarotImageService = tarotImageService;
        }
        [HttpPost("add")]
        public IActionResult Add([FromForm(Name = ("Image"))] IFormFile file, [FromForm] TarotImage tarotImage)
        {
            var result = _tarotImageService.Add(file, tarotImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _tarotImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getimagesbycardnum")]
        public IActionResult GetByCardNum([FromForm(Name = ("CarId"))] int carId)
        {
            var result = _tarotImageService.GetByCardNum(carId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
