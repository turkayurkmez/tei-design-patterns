using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface ISortStrategegy
    {
        void Sort();
    }

    public class BubbleSort : ISortStrategegy
    {
        public void Sort()
        {
            Console.WriteLine("Bubble sıralama algoritması");
        }
    }

    public class HeapSort : ISortStrategegy
    {
        public void Sort()
        {
            Console.WriteLine("Heap sıralama algoritması");
        }


      
    }


    public class CustomCollection
    {

        private ISortStrategegy sortStrategegy;

        public CustomCollection(ISortStrategegy sortStrategegy)
        {
            this.sortStrategegy = sortStrategegy;
        }

        public void Sort()
        {
            //Gelecekte algoritmayı değiştirmek istediğinizde, ISortStrategegy arayüzünü implemente edin.
            sortStrategegy.Sort();
        }
    }
}
