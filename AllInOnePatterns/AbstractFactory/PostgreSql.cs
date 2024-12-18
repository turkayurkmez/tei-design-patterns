using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class PostgreSqlConnection : IConnection
    {
        public void Connect()
        {
            Console.WriteLine("Postgre db'ye bağlanıyor");
        }

        public void Disconnect()
        {
            Console.WriteLine("Postgre db'den bağlantı kesiliyor");

        }
    }

    public class PostgreSqlCommand : ICommand
    {
        public void Execute(string query)
        {
            Console.WriteLine($"PostgreSql sorgusu çalıştırılıyor: {query}");
        }
    }

    public class PostgreSqlDataReader : IDataReader
    {
        public void Read()
        {
            Console.WriteLine("PostgreSql data okunuyor");
        }
    }
}
