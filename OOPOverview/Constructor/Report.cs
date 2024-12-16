using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{

    public class Report
    {

        public string Format { get; set; }
        public string ExcelFilePath { get; set; }
        //public Report()
        //{
        //    Format = "PDF";
        //}

        //public Report(string format)
        //{
        //    Format = format;
        //}


        /// <summary>
        /// Bir excel dosyası içerisindeki veriyi, rapora dönüştüren nesne. Varsayılan Format: PDF
        /// </summary>
        /// <param name="excelFilePath">Verilerin bulunduğu excel dosyası</param>
        public Report(string excelFilePath): this(excelFilePath,"PDF")
        {

            
        }


        /// <summary>
        /// Bir excel dosyası içerisindeki veriyi, rapora dönüştüren nesne.
        /// </summary>
        /// <param name="excelFilePath">Verilerin bulunduğu excel dosyası</param>
        /// <param name="format">Rapor Formatı</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        public Report(string excelFilePath, string format)
        {
            if (string.IsNullOrEmpty(excelFilePath))
            {
                throw new ArgumentNullException();
            }
            if (!File.Exists(excelFilePath))
            {
                throw new FileNotFoundException($"{excelFilePath} dosyası bulunamadı");
            }

            this.Format = format;
        }


    }

}
