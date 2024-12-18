using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IDbFactory
    {
        IConnection CreateConnection();
        ICommand CreateCommand();
        IDataReader CreateDataReader();
    }

    public class PostgreSqlFactory : IDbFactory
    {
        public IConnection CreateConnection()
        {
            return new PostgreSqlConnection();
        }
        public ICommand CreateCommand()
        {
            return new PostgreSqlCommand();
        }
        public IDataReader CreateDataReader()
        {
            return new PostgreSqlDataReader();
        }
    }

    public class MicrosoftSqlServerFactory : IDbFactory
    {
        public IConnection CreateConnection()
        {
            return new MicrosoftSqlServerConnection();
        }
        public ICommand CreateCommand()
        {
            return new MicrosoftSqlServerCommand();
        }
        public IDataReader CreateDataReader()
        {
            return new MicrosoftSqlServerDataReader();
        }
    }


}
