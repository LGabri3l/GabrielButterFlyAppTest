using GabrielButterfly.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GabrielButterFly.API.Controllers
{
    [Route("GabrielButterFly/[controller]")]
    [ApiController]
    public class SubtractionController : ControllerBase
    {
        private readonly ISubtraction _subtraction;

        public SubtractionController(ISubtraction subtraction)
        {
            _subtraction = subtraction ?? throw new ArgumentNullException(nameof(subtraction));
        }

        [HttpGet("Sub")]

        public async Task<IActionResult> GetSubtractionResul([FromQuery] int num1, [FromQuery] int num2)
        {
            try
            {
                var result = await _subtraction.Subtraction(num1, num2);
                return Ok(result.resultSub);
            }

            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }

        }
    }
}
