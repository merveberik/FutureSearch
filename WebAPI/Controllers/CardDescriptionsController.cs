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
    public class CardDescriptionsController : ControllerBase
    {
        private ICardDescriptionService _cardDescriptionService;

        public CardDescriptionsController(ICardDescriptionService cardDescriptionService)
        {
            _cardDescriptionService = cardDescriptionService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _cardDescriptionService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("add")]
        public IActionResult Add(CardDescription cardDescription)
        {
            var result = _cardDescriptionService.Add(cardDescription);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(CardDescription cardDescription)
        {
            var result = _cardDescriptionService.Update(cardDescription);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
