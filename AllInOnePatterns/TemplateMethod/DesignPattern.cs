using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public interface IRunnable
    {
        void Run();
    }

    public abstract class DataAccessObject : IRunnable
    {
        //1. db'ye bağlan:
        public abstract void Connect();
        //2. bağlantıyı kontrol et:
        public bool IsConnected { get; set; }
        //3. Select içeren prosedürü çağır
        public abstract void ExecuteSelect();
        public abstract void Process();
        public abstract void Disconnect();

        public void Run()
        {
            Connect();
            if (IsConnected)
            {
                ExecuteSelect();
                Process();
                Disconnect();
            }
        }

       



    }
    public class SelectAllProductsDto : DataAccessObject
    {
        public override void Connect()
        {
            Console.WriteLine("db'ye bağlandı");
            IsConnected = true;
        }

        public override void Disconnect()
        {
            Console.WriteLine("bağlantı kapatıldı");
        }

        public override void ExecuteSelect()
        {
            Console.WriteLine("SELECT ile ürün sorgusu çekildi");
        }

        public override void Process()
        {
            Console.WriteLine("Veri gösterildi");
        }
    }
    public class SelectAllCustomersDto : DataAccessObject
    {
        public override void Connect()
        {
            Console.WriteLine("db'ye bağlandı");
            IsConnected = true;
        }

        public override void Disconnect()
        {
            Console.WriteLine("bağlantı kapatıldı");
        }

        public override void ExecuteSelect()
        {
            Console.WriteLine("SELECT ie müşteri sorgusu çekildi");
        }

        public override void Process()
        {
            Console.WriteLine("Veri gösterildi");
        }
    }
}
