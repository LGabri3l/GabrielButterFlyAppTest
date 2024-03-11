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
            _addition = addition ?? throw new ArgumentNullException(nameof(addition));
        }

        [HttpGet("Add")]

        public async Task<IActionResult> GetAdditionResult([FromQuery] int num1, [FromQuery] int num2)
        {
            try
            {
                var result = await _addition.Addition(num1, num2);
                return Ok(result.resultAdd);
            }

            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
    }
}
