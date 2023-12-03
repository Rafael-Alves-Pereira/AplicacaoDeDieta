using AplicacaoDeDieta.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoDeDieta.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnalyticsListController : ControllerBase
    {

        private readonly ILogger<AnalyticsListController> _logger;

        public AnalyticsListController(ILogger<AnalyticsListController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAnalyticsList")]
        public IActionResult Get()
        {
            var result = new
            {
                qualAnalytics = new[]
                {
                    new { name = "Comment", type = "text/plain" }
                },
                quantAnalytics = new[]
                {
                    new { name = "Filling", type = "integer" },
                    new { name = "Taste", type = "integer" },
                    new { name = "Complexity", type = "integer" },
                    new { name = "Recommendation", type = "bool" }
                }
            };

            return Ok(result);
        }
    }
}