using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class DbManager(IDbFactory dbFactory)
    {
        public void Execute(string query)
        {
            IConnection connection = dbFactory.CreateConnection();
            connection.Connect();
            ICommand command = dbFactory.CreateCommand();
            command.Execute(query);
            IDataReader reader = dbFactory.CreateDataReader();
            reader.Read();
            connection.Disconnect();
        }
    }
}
