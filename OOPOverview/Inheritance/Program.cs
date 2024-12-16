using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public  class Program
    {
        public static void Main()
        {
            Tavuk kizartma = new Tavuk() { PismeSuresi = 35};
            Dana kebap = new Dana() { PismeSuresi = 45};
            DomatesCorbasi domatesCorbasi = new DomatesCorbasi() { PismeSuresi = 15};           
            Tulumba tatli = new Tulumba() {  PismeSuresi = 20};

            Asci asci = new Asci();
            asci.Pisir(kizartma);
            asci.Pisir(kebap);
            asci.Pisir(domatesCorbasi);
            asci.Pisir(tatli);

            Console.WriteLine("---------------------------");
            DomatesCorbasi corba = new DomatesCorbasi();
            corba.Pisir();
            corba.SunumYap();

        }
    }
}
