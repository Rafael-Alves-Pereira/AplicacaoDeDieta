using AplicacaoDeDieta.Models;

namespace AplicacaoDeDieta.Services
{
    public interface IAnalyticsService
    {
        List<AnalyticsResponse> GetAnalytics(AnalyticsRequest analyticsRequest);
    }


}