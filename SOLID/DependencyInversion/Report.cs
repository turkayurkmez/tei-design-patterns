using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{

    public class DefaultSender
    {
        public static MailSender MailSender = new MailSender();
        public static WhatsAppSender WhatsAppSender = new WhatsAppSender();
        public static TelegramSender TelegramSender = new TelegramSender();

    }
    public class Report
    {

        private readonly ISender sender;



        public Report(ISender sender)
        {
             this.sender = sender;
        }

        public void Send()
        {

            sender.Send();
        }

    }

    public interface ISender
    {
        void Send();
    }
    public class MailSender : ISender
    {
        public void Send() => Console.WriteLine("Mail Gönderildi");
    }

    public class SmsSender : ISender
    {
        public void Send() => Console.WriteLine("Sms Gönderildi");
    }

    public class WhatsAppSender : ISender
    {
        public void Send() => Console.WriteLine("WhatsApp ile Gönderildi");

    }

    public class TelegramSender : ISender
    {
        public void Send() => Console.WriteLine("Telegram ile Gönderildi");
    }

    public class TestSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Gelecekte ihtiyaç.....");
        }
    }

}
