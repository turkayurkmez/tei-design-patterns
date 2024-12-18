using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    //3. Finansal Rapor olarak özelleştirilmiş bir rapor oluşturacak olan sınıfı tanımlayın
    internal class FinancialReportBuilder : IReportBuilder
    {
        private Report _report = new Report();

        public FinancialReportBuilder()
        {
            _report.Author = "TEİ Finans Departmanı";
            

        }
        public IReportBuilder BuildCharts()
        {
            _report.Charts.Add("Harcama pasta grafiği");
            _report.Charts.Add("Departmana göre bütçe bar grafği");
            
            return this;
        }
        public IReportBuilder BuildContent()
        {
            _report.Content = "2024 Yılsonu Bütçe Analiz Raporu";
            return this;
        }
        public IReportBuilder BuildFooter()
        {
            _report.Footer = "Bu rapor TEİ Report Generator tarafından olıuşturuldu";
            return this;
        }
        public IReportBuilder BuildHeader()
        {
            _report.Header = "TEİ Finans Raporu";
            return this;
        }
        public IReportBuilder BuildTables()
        {
            _report.Tables.Add("Gelir Tablosu");
            _report.Tables.Add("Gider Tablosu");
            _report.Tables.Add("Özet tablo");
            return this;
        }
        public IReportBuilder BuildTitle()
        {
            _report.Title = "2024 Yıl sonu bütçe analizi";
            return this;
        }
        public Report GetReport()
        {
            return _report;
        }
    }
   
}
