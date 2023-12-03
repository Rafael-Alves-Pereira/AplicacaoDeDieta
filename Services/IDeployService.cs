using AplicacaoDeDieta.Models;

namespace AplicacaoDeDieta.Services
{
    public interface IDeployService
    {
        string PrepareActivity(string activityId);
        string BeginActivity(DeployRequest deployRequest);
    }


}