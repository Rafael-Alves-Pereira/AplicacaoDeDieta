namespace AplicacaoDeDieta.Models
{
    public class AnalyticsResponse
    {
        public string InveniraStdID { get; set; }
        public List<QuantAnalytics> QuantAnalytics { get; set; }
        public List<QualAnalytics> QualAnalytics { get; set; }
    }

    public class QuantAnalytics
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public dynamic Value { get; set; }
    }

    public class QualAnalytics
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
    }
}