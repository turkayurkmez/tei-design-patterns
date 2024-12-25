// See https://aka.ms/new-console-template for more information
using Facade;

Console.WriteLine("Hello, World!");
/*
 * Problem:
 * 
 *   Çok karmaşık (çok nesneli akışlar, transaction vs) bir işlemi, 
 *   yazılımcının basit bir nesne->metod çağrısıyla basitleştirmek istiyorsunuz.
 *   
 *   Çözüm:
 *   Facade ile karmaşayı arkaya itin.
 */

OrderService orderService = new OrderService();
Customer customer = new Customer() { Name ="Türkay"};
OrderItem item = new OrderItem() { OrderId=1, ProductId=8, Quantity=20, Product=new Product { Name= "Güneş Gözlüğü", Stock=100} };
OrderItem item2 = new OrderItem() { OrderId = 1, ProductId = 18, Quantity = 5, Product = new Product { Name = "Şapka", Stock = 250 } };

var orderItems = new List<OrderItem> { item, item2 };
orderService.CreateOrder(customer, orderItems);