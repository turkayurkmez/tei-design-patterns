using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class EmployeePerformanceReportBuilder : IReportBuilder
    {
        Report report = new Report();
        public IReportBuilder BuildCharts()
        {
            report.Charts.Add("Çalışan performansı pasta grafiği");
            report.Charts.Add("Departman performansı bar grafği");
            return this;

        }

        public IReportBuilder BuildContent()
        {
            report.Content = "2024 Yılsonu Performans Analiz Raporu";
            return this;
        }

        public IReportBuilder BuildFooter()
        {
            report.Footer = "Bu rapor TEİ Report Generator tarafından oluşturuldu";
            return this;
        }

        public IReportBuilder BuildHeader()
        {
             report.Header = "TEİ Performans Raporu";
            return this;
        }

        public IReportBuilder BuildTables()
        {
            report.Tables.Add("Çalışan performans tablosu");
            report.Tables.Add("Departman performans tablosu");
            report.Tables.Add("Özet tablo");
            return this;

        }

        public IReportBuilder BuildTitle()
        {
           report.Title = "2024 Yıl sonu performans analizi";
            return this;
        }

        public Report GetReport()
        {
           return report;
        }
    }
}
