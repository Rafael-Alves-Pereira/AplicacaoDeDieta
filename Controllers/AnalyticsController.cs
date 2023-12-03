using AplicacaoDeDieta.Models;
using Microsoft.AspNetCore.Mvc;
using AplicacaoDeDieta.Services;
using System.Collections.Generic;

namespace AplicacaoDeDieta.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnalyticsController : ControllerBase
    {
        private readonly IAnalyticsService _analyticsService;

        public AnalyticsController(IAnalyticsService analyticsService)
        {
            _analyticsService = analyticsService;
        }

        [HttpPost]
        [Route("GetAnalytics")]
        public IActionResult GetAnalytics([FromBody] AnalyticsRequest analyticsRequest)
        {
            var analyticsResponse = _analyticsService.GetAnalytics(analyticsRequest);

            return Ok(analyticsResponse);
        }
    }
}