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
            _multiplication = multiplication;
        }

        [HttpGet]

        public async Task<IActionResult> GetMultiplicationResult(int num1, int num2)
        {
            var result = await _multiplication.Multiplication(num1, num2);
            return Ok(result);
        }
    }
}

