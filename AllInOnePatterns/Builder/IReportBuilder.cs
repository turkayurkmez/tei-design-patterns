using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    //2. Report nesnesini oluşturacak olan arayüzü belirleyin (Rapor nesnesi nasıl oluşacak?)
    public interface IReportBuilder
    {
        IReportBuilder BuildHeader();
        IReportBuilder BuildTitle();
        IReportBuilder BuildContent();
        IReportBuilder BuildFooter();
        IReportBuilder BuildTables();
        IReportBuilder BuildCharts();
        Report GetReport();
    }
}
