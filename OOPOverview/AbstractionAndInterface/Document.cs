using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndInterface
{
    public abstract class Document
    {
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }

        //Document sınıfını miras alan diğer sınıflar, Save metodunu ezmeye mecburdur!
        public abstract void Save(string path);
        public abstract void Open(string path);
        

        public void Copy(string from,  string to)
        {
            Console.WriteLine($"{from} adresinden {to} adresine koplayandı");
        }
       
    }

    public interface IPrintable
    {
        void Print();
    }
    public class PdfDocument : Document
    {
        public override void Open(string path)
        {
            Console.WriteLine("PDF Dosyası açıldı");
        }

     

        public override void Save(string path)
        {
            Console.WriteLine("PDF Kaydedildi!");
        }
    }

    public class ExcelDocument : Document, IPrintable
    {
        public override void Open(string path)
        {
            Console.WriteLine("Excel açıldı");
        }

        public void Print()
        {
            Console.WriteLine("Excel çıktısı alındı");
        }

        public override void Save(string path)
        {
            throw new NotImplementedException();
        }
    }

    public class WordDocument : Document, IPrintable
    {
        public override void Open(string path)
        {
            Console.WriteLine("Word açıldı");
        }

        public void Print()
        {
            Console.WriteLine("Word çıktısı alındı");

        }

        public override void Save(string path)
        {
            Console.WriteLine("Word kaydedildi");
        }
    }

    public class DocumentSaver
    {
        public void SaveDocument(Document document, string path)
        {
            document.Save(path);
        }
    }

    public class DocumentPrinter
    {
        public void PrintDocument(IPrintable document)
        {
            document.Print();
        }
    }   
}
