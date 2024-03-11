using GabrielButterfly.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GabrielButterFly.API.Controllers
{
    [Route("GabrielButterFly/[controller]")]
    [ApiController]
    public class MultiplicationController : ControllerBase
    {
        private readonly IMultiplication _multiplication;

        public MultiplicationController(IMultiplication multiplication)
        {
            _multiplication = multiplication ?? throw new ArgumentNullException(nameof(multiplication));
        }

        [HttpGet("Mult")]

        public async Task<IActionResult> GetMultiplicationResult([FromQuery] int num1, [FromQuery] int num2)
        {
            try
            {
                var result = await _multiplication.Multiplication(num1, num2);
                return Ok(result.resultMul);
            }

            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
    }
}

