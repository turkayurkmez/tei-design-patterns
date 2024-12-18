// See https://aka.ms/new-console-template for more information
using Bridge;

Console.WriteLine("Hello, World!");


FinancialReport financialReport = new FinancialReport() { Format = new PdfReportFormat()};
FinancialReport financialReportWithExcel = new FinancialReport() { Format = new ExcelReportFormat() };
