using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IConnection
    {
        void Connect();
        void Disconnect();
    }

    public interface ICommand
    {
        void Execute(string query);
    }

    public interface IDataReader
    {
        void Read();
    }
}
