// See https://aka.ms/new-console-template for more information
using AbstractionAndInterface;

Console.WriteLine("Hello, World!");

WordDocument wordDocument = new WordDocument();
ExcelDocument excelDocument = new ExcelDocument();
PdfDocument pdfDocument = new PdfDocument();    

DocumentPrinter  printer = new DocumentPrinter();
printer.PrintDocument(wordDocument);
printer.PrintDocument(excelDocument);
//printer.PrintDocument(pdfDocument);

