using AplicacaoDeDieta.Services;

namespace AplicacaoDeDieta.Models
{
    public class DeployRequest
    {
        public string ActivityID { get; set; }
        public string InvenRAstdID { get; set; }
        public IDeployService JsonParams { get; set; }
    }

}