namespace DynamicChartDashboard.Models
{
    public class SalesData
    {
        public int Id { get; set; }

        public int Year { get; set; }

        public string Month { get; set; } = string.Empty;

        public int MonthNumber { get; set; }

        public decimal SalesAmount { get; set; }
    }
}
