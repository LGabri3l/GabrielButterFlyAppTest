using GabrielButterfly.Core.Entities;
using GabrielButterfly.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GabrielButterFly.API.Controllers
{
    [Route("GabrielButterFly/[controller]")]
    [ApiController]
    public class AdditionController : ControllerBase
    {        
        private readonly IAddition _addition;

        public AdditionController(IAddition addition)
        {
            _addition = addition;
        }

        [HttpGet]

        public async Task<IActionResult> GetAdditionResult(int num1, int num2)
        {
            var result = await _addition.Addition(num1, num2);
            return Ok(result);
        }
    }
}
