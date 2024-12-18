using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class MailConfiguration
    {
        private MailConfiguration()
        {
            Console.WriteLine("MailConfiguration nesnesi oluşturuldu.");
        }

        private readonly object _lock = new object();

        public string Host { get; set; }
        public string Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public void Send()
        {
            lock (_lock)
            {
                Console.WriteLine("Mail gönderiliyor...");
            }
        }
        //private static MailConfiguration _instance;

            ////lazy initialization:
            //public static MailConfiguration CreateInstance()
            //{
            //    if (_instance == null)
            //    {
            //        _instance = new MailConfiguration();
            //    }
            //    return _instance;
            //}

        private static readonly Lazy<MailConfiguration> _instance = new Lazy<MailConfiguration>(() => new MailConfiguration());

        public static MailConfiguration Instance => _instance.Value;

    }
}
