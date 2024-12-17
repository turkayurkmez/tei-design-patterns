// See https://aka.ms/new-console-template for more information
using OCP;

Console.WriteLine("Hello, World!");

//Bir nesne ....gelişime... AÇIK ....değişime...... KAPALI olmalıdır.
Customer customer = new Customer { Name = "Türkay", LoyaltyCard = new PremiumCard() };
OrderManagement orderManagement = new OrderManagement { Customer = customer };
var result = orderManagement.ApplyDiscount(1000);
Console.WriteLine(result);
