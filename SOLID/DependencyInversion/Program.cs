// See https://aka.ms/new-console-template for more information
using DependencyInversion;

Console.WriteLine("Hello, World!");

// Dependency Inversion Principle: 
// Düşük seviyeli nesneler yüksek seviyeli nesnelere bağlı olmamalıdır. Bunun yerine her ikisi de soyutlamalara bağlı olmalıdır.

MailSender mailSender = new MailSender();
WhatsAppSender whatsAppSender = new WhatsAppSender();
TelegramSender telegramSender = new TelegramSender();


Report report = new Report(mailSender);
report.Send();  

Report report2 = new Report(whatsAppSender);
report2.Send();


Report report3 = new Report(telegramSender);
report3.Send();

Report report4 = new Report(new TestSender());
report4.Send();

