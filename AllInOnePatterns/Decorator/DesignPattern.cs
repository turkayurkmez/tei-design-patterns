using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
  /*
   * Senaryo: Şirket içi mesajlaşma uygulaması.
   *    İsteğe bağlı olarak -> Mesaj sıkıştırılsın
   *                        -> Şifrelensin
   *                        -> İmza eklensin
   *                        -> ..........
   *                        
   *                        
   */

    public interface IMessage
    {
        void Send();
    }

    public class Message : IMessage
    {
        public void Send()
        {
            Console.WriteLine("Mesaj iletildi");
        }
    }


    public abstract class MessageDecorator : IMessage
    {
        private readonly IMessage message;

        protected MessageDecorator(IMessage message)
        {
            this.message = message;
        }

        public void Send()
        {
            message.Send();
        }
    }

    public class ZippedMessageDecorator : MessageDecorator
    {
        public ZippedMessageDecorator(IMessage message) : base(message)
        {
        }

        public void Zip()
        {
            Console.WriteLine($"Mesaj {ZippedRate} sıkıştırıldı!");
        }

        public double ZippedRate { get; set; }


    }

    public class CryptedMessageDecorator : MessageDecorator
    {
        public CryptedMessageDecorator(IMessage message) : base(message)
        {
        }

        public void Crypted() {
            Console.WriteLine($"Mesaj, {CryptoAlgorithm} ile şifrelendi");
        }

        public string CryptoAlgorithm { get; set; }
    }

    public class AddSignMessageDecorator : MessageDecorator
    {
        public AddSignMessageDecorator(IMessage message) : base(message)
        {
        }

        public void AddSign(string sign) {
            Console.WriteLine($"İmza olarak, {sign} eklendi");
        }
    }
}
