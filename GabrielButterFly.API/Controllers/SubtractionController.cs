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
            _subtraction = subtraction;
        }

        [HttpGet]

        public async Task<IActionResult> GetSubtractionResul(int num1, int num2)
        {            
            var result = await _subtraction.Subtraction(num1, num2);
            return Ok(result);
                      
        }
    }
}
