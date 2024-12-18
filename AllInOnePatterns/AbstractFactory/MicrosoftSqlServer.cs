using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MicrosoftSqlServerConnection : IConnection
    {
        public void Connect()
        {
            Console.WriteLine("Microsoft Sql Server db'ye bağlanıyor");
        }
        public void Disconnect()
        {
            Console.WriteLine("Microsoft Sql Server db'den bağlantı kesiliyor");
        }
    }

    public class MicrosoftSqlServerCommand : ICommand
    {
        public void Execute(string query)
        {
            Console.WriteLine($"Microsoft Sql Server sorgusu çalıştırılıyor: {query}");
        }
    }

    public class MicrosoftSqlServerDataReader : IDataReader
    {
        public void Read()
        {
            Console.WriteLine("Microsoft Sql Server data okunuyor");
        }
    }

}
