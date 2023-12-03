using AplicacaoDeDieta.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoDeDieta.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConfigPageController : ControllerBase
    {

        private readonly ILogger<ConfigPageController> _logger;

        public ConfigPageController(ILogger<ConfigPageController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetConfigPage")]
        public IActionResult Get()
        {
            var result = new
            {
                Description = new { name = "despcription", type = "text/plain" },
                Url = new { name = "url", type = "URL" }
            };

            return Ok(result);
        }
    }
}