// See https://aka.ms/new-console-template for more information
using ClassAndObjects;

Console.WriteLine("Hello, World!");

Person yazilimci = new Person();
yazilimci.Name = "Türkay";
yazilimci.Age = 44;

Person muhasebeci = yazilimci;

muhasebeci.Name = "Mehmet";
muhasebeci.Age = 33;

Console.WriteLine("Yazılımcı nesnesi:");
Console.WriteLine(yazilimci.Name);
Console.WriteLine(yazilimci.Age);
Console.WriteLine("-------------------------------------");
Console.WriteLine("Muhasebeci nesnesi:");
Console.WriteLine(muhasebeci.Name);
Console.WriteLine(muhasebeci.Age);


