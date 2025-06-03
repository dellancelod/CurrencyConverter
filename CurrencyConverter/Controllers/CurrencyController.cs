using Microsoft.AspNetCore.Mvc;

namespace CurrencyApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CurrencyController : ControllerBase
    {
        private const decimal UsdToUahRate = 39.5m;

        [HttpGet("toUsd")]
        public IActionResult ConvertToUsd([FromQuery] decimal uah)
        {
            var usd = uah / UsdToUahRate;
            return Ok(usd);
        }

        [HttpGet("toUah")]
        public IActionResult ConvertToUah([FromQuery] decimal usd)
        {
            var uah = usd * UsdToUahRate;
            return Ok(uah);
        }
    }
}
