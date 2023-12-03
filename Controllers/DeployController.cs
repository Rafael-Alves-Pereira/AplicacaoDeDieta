using AplicacaoDeDieta.Models;
using Microsoft.AspNetCore.Mvc;
using AplicacaoDeDieta.Services;

namespace AplicacaoDeDieta.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeployController : ControllerBase
    {
        private readonly IDeployService _deployService;

        public DeployController(IDeployService deployService)
        {
            _deployService = deployService;
        }

        [HttpGet]
        [Route("ProvisionarAtividade")]
        public IActionResult ProvisionarAtividade(string activityId)
        {
            // L�gica para preparar a atividade e gerar o URL
            var deployUrl = _deployService.PrepareActivity(activityId);

            // Retorne o URL gerado
            return Ok(new Deploy { UserUrl = deployUrl });
        }

        [HttpPost]
        [Route("BeginActivity")]
        public IActionResult BeginActivity([FromBody] DeployRequest deployRequest)
        {
            // L�gica para registrar dados anal�ticos e gerar o URL de redirecionamento
            var redirectUrl = _deployService.BeginActivity(deployRequest);

            // Retorne o URL para o qual ser� redirecionado o aluno
            return Ok(new Deploy { RedirectUrl = redirectUrl });
        }
    }
}
