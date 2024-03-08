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
            _division = division;
        }

        [HttpGet]

        public async Task<IActionResult> GetDivisionResult(int num1, int num2)
        {
            var result = await _division.Division(num1, num2);
            return Ok(result);
        }
    }
}

