using AplicacaoDeDieta.Models;
using System.Collections.Generic;

namespace AplicacaoDeDieta.Services
{
    public class AnalyticsService : IAnalyticsService
    {
        public List<AnalyticsResponse> GetAnalytics(AnalyticsRequest analyticsRequest)
        {
            // Lógica para obter os analytics conforme o pedido

            // Exemplo de resposta
            var analyticsResponseList = new List<AnalyticsResponse>
        {
            new AnalyticsResponse
            {
                InveniraStdID = "1001",
                QuantAnalytics = new List<QuantAnalytics>
                {
                    new QuantAnalytics { Name = "Accessed Activity", Type = "boolean", Value = true },
                    new QuantAnalytics { Name = "Download Document 1", Type = "boolean", Value = true },
                    new QuantAnalytics { Name = "Activity Evolution (%)", Type = "float", Value = 33.3 }
                },
                QualAnalytics = new List<QualAnalytics>
                {
                    new QualAnalytics { Name = "User activity profile", Type = "text/plain", Value = "https://ActivityProvider/?APAnID=11111111" },
                    new QualAnalytics { Name = "Actitivy Heat Map", Type = "URL", Value = "https://ActivityProvider/?APAnID=21111111" }
                }
            },
            new AnalyticsResponse
            {
                InveniraStdID = "1002",
                QuantAnalytics = new List<QuantAnalytics>
                {
                    new QuantAnalytics { Name = "Accessed Activity", Type = "boolean", Value = true },
                    new QuantAnalytics { Name = "Download Document 1", Type = "boolean", Value = false },
                    new QuantAnalytics { Name = "Activity Evolution (%)", Type = "float", Value = 10.0 }
                },
                QualAnalytics = new List<QualAnalytics>
                {
                    new QualAnalytics { Name = "User activity profile", Type = "text/plain", Value = "https://ActivityProvider/?APAnID=11111112" },
                    new QualAnalytics { Name = "Actitivy Heat Map", Type = "URL", Value = "https://ActivityProvider/?APAnID=21111112" }
                }
            }
        };

            return analyticsResponseList;
        }
    }


}