using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{

    //1. Adaptör arayüzü:
    public interface IDataProcessor<T>
    {
        IList<T> ReadData();
    }


    //2. Uygulama sınıfı:
    public class JsonDataProcessor : IDataProcessor<string>
    {
        public IList<string> ReadData()
        {
            //Json dosyasından veri okuma işlemleri
            return new List<string>() { "json1", "json2", "json3" };
        }
    }

    //3. XML veri okuma sınıfı:
    public class XmlDataProcessor : IDataProcessor<string>
    {
        public IList<string> ReadData()
        {
            //XML dosyasından veri okuma işlemleri
            return new List<string>() { "XML1", "XML2", "XML3" };
        }
    }

    //Adaptee:
 


}
