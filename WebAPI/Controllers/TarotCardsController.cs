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
    public class TarotCardsController : ControllerBase
    {
        private ITarotCardService _tarotCardService;

        public TarotCardsController(ITarotCardService tarotCardService)
        {
            _tarotCardService = tarotCardService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _tarotCardService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("add")]
        public IActionResult Add(TarotCard tarotCard)
        {
            var result = _tarotCardService.Add(tarotCard);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(TarotCard tarotCard)
        {
            var result = _tarotCardService.Update(tarotCard);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
