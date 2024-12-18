using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	public interface IMailConfiguration
	{

        string Host { get; set; }
        string Port { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string Email { get; set; }

    }

}
