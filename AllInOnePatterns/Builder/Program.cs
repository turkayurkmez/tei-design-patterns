// See https://aka.ms/new-console-template for more information
using Builder;

Console.WriteLine("Hello, World!");

/*
 * Builder Pattern hangi durumlarda kullanılır?
 *   Çok fazla aşamadan geçerek bir nesneyi oluşturmanız gerekiyorsa... 
 * 
 *  1. Bir nesnenin karmaşık yapısını oluşturmak istediğinizde.
 *  2. Bir nesnenin farklı varyasyonlarını oluşturmak istediğinizde.
 *  
 *  
 *  Senaryo:
 *  Bir rapor oluşturmak istiyoruz. Raporun başlık, ana başlık, içerik, Tablolar, grafikler ve imzadan oluşmasını istiyoruz.
 *  
 *  
 * 
 */

//1. Finansal rapor oluşturmak için bir builder oluşturuyoruz
var financialReportBuilder = new FinancialReportBuilder();
//2. Raporu oluşturacak olan yöneticiyi oluşturuyoruz
var reportDirector = new ReportDirector(financialReportBuilder);
//3. Raporu oluşturuyoruz
var financialReport = reportDirector.BuildFullReport();
//4. Raporu yazdırıyoruz
financialReport.PrintReport();

//1. Minimal rapor oluşturmak için bir builder oluşturuyoruz
var minimalReportBuilder = new EmployeePerformanceReportBuilder();
//2. Raporu oluşturacak olan yöneticiyi oluşturuyoruz
var reportDirector2 = new ReportDirector(minimalReportBuilder);
//3. Raporu oluşturuyoruz
var minimalReport = reportDirector2.BuildMinimalReport();
//4. Raporu yazdırıyoruz
minimalReport.PrintReport();



