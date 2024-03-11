using GabrielButterfly.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GabrielButterFly.API.Controllers
{
    [Route("GabrielButterFly/[controller]")]
    [ApiController]
    public class DivisionController : ControllerBase
    {
        private readonly IDivision _division;

        public DivisionController(IDivision division)
        {
            _division = division ?? throw new ArgumentNullException(nameof(division));
        }

        [HttpGet("Div")]

        public async Task<IActionResult> GetDivisionResult([FromQuery] int num1, [FromQuery] int num2)
        {
            try
            {
                var result = await _division.Division(num1, num2);
                return Ok(result.resultDiv);
            }

            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
    }
}

