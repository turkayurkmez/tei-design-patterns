// See https://aka.ms/new-console-template for more information
using Command;

Console.WriteLine("Hello, World!");
/*
 * Problem:
 *    Bir uygulamada, arayüzden gelen komutların 'geri alınabilir' formatta yapılandırmak istiyorsunuz? Nasıl bir tasarım yaparsınız.
 *    
 * Çözüm: Command Pattern!
 */

DbCommandReceiver dbCommandReceiver = new DbCommandReceiver();
CreateNewProductCommand createNewProduct = new CreateNewProductCommand(dbCommandReceiver) { Id = 1, Name ="Monitör", Price=1500};
DiscountProductCommand discountProduct = new DiscountProductCommand(dbCommandReceiver) { ProductId =1, Price=1000 };



CommandInvoker commandInvoker = new CommandInvoker();
commandInvoker.Add(createNewProduct);
commandInvoker.Add(discountProduct);
commandInvoker.Clear();
commandInvoker.RemoveCommand(discountProduct);
commandInvoker.ExecuteCommands();