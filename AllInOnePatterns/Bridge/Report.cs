using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{

    //Soru: has a is a ilişkisi nedir?
    public class Report
    {
        public ReportFormat Format { get; set; }
    }

    public class HRReport : Report
    {
      
    }

    public class FinancialReport : Report
    {

    }

    public class  ITReport: Report
    {
        
    }


    public abstract class ReportFormat
    {
        public abstract void ShowFormatInfo();
       
    }

    public class PdfReportFormat : ReportFormat
    {
        public override void ShowFormatInfo()
        {
            Console.WriteLine("Pdf formatında rapor oluşturuldu.");
        }
    }

    public class ExcelReportFormat : ReportFormat
    {
        public override void ShowFormatInfo()
        {
            Console.WriteLine("Excel formatında rapor oluşturuldu.");
        }
    }

    public class WordReportFormat : ReportFormat
    {
        public override void ShowFormatInfo()
        {
            Console.WriteLine("Word formatında rapor oluşturuldu.");
        }
    }

    public class XmlReportFormat : ReportFormat
    {
        public override void ShowFormatInfo()
        {
            Console.WriteLine("Xml formatında rapor oluşturuldu.");
        }
    }






}
