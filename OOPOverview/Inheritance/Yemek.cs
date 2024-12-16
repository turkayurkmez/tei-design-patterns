using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Yemek
    {
        public int PismeSuresi { get; set; }
        public List<string> Malzemeler { get; set; }

        public void Pisir()
        {
            Console.WriteLine($"{GetType().Name} isimli ürün, {PismeSuresi} dakikada pişti");
        }

        //Eğer istenirse, SunumYap fonksiyonu, miras alanlar tarafından ezilebilir!
        public virtual void SunumYap()
        {
            Console.WriteLine($" {GetType().Name} Yanında pilav ile sunuldu.....");
        }
    }

    //Çorba, bir yemektir.
    public class Corba : Yemek
    {
        public bool LimonOlsunMu { get; set; }

        public override void SunumYap()
        {
            Console.WriteLine($" {GetType().Name} Yanında baharatla sunuldu.....");

        }
    }

    public class DomatesCorbasi : Corba
    {
        public bool KasarliMi { get; set; }
    }

    public class EtYemek : Yemek
    {
        public string SosBilgisi { get; set; }
    }

    public class Tavuk : EtYemek
    {

    }

    public class Dana : EtYemek { }

    public class Tatli : Yemek
    {
        public override void SunumYap()
        {
            Console.WriteLine($"{GetType().Name }, yanında su  ile sunuldu");
        }
    }

    public class Tulumba : Tatli
    {

    }
}
