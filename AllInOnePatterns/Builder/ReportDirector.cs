using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    //4. Hangi raporun oluşturulacağını yöneten sınıfı tanımlayın
    public class ReportDirector (IReportBuilder reportBuilder)
    {
        public Report BuildFullReport()
        {
            return reportBuilder
                     .BuildHeader()
                     .BuildTitle()
                     .BuildContent()
                     .BuildTables()
                     .BuildCharts()
                     .BuildFooter()
                     .GetReport();
        }

        public Report BuildMinimalReport()
        {
            return reportBuilder
                     .BuildHeader()
                     .BuildTitle()
                     .BuildContent()
                     .BuildFooter()
                     .GetReport();
        }
    }
}
