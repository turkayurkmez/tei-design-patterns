using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{

    //1. Build edeceğiniz nesnenin yapısını belirleyin (Ne elde edeceksiniz?)
    public class Report
    {
        public string Header { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Footer { get; set; }

        public string Author { get; set; }

        public List<string> Tables { get; set; } = new List<string>();
        public List<string> Charts { get; set; } = new List<string>();

        public void PrintReport()
        {
            Console.WriteLine("Header: " + Header);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Content: " + Content);
            Console.WriteLine("Footer: " + Footer);
            Console.WriteLine("Tables: ");
            foreach (var table in Tables)
            {
                Console.WriteLine(table);
            }
            Console.WriteLine("Charts: ");
            foreach (var chart in Charts)
            {
                Console.WriteLine(chart);
            }
        }

    }
}
