// See https://aka.ms/new-console-template for more information
using Singleton;

Console.WriteLine("Hello, World!");
/*
 * Singleton Pattern
 * 
 * Problem:
 *   Uygulamanızda, birim zamanda sadece bir nesne oluşturulmasını istiyorsunuz.
 *   
 */

var mailConfig = MailConfiguration.Instance;
mailConfig.Host = "smtp.gmail.com";
mailConfig.Port = "587";

//show mail configuration host:
Console.WriteLine($"Gmail host: {mailConfig.Host}");

//diğer nesne:
var outlookConfig = MailConfiguration.Instance;
outlookConfig.Host = "smtp.outlook.com";
Console.WriteLine($"Outlook Host: {outlookConfig.Host}");
Console.WriteLine($"Port: {outlookConfig.Port}");