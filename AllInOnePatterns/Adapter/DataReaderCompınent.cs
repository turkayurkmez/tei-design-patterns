using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class DataReaderComponent
    {
        public IList<string> ReadData(IDataProcessor<string> dataProcessor)
        {
            var data = dataProcessor.ReadData();
            return data;
        }
    }
}
