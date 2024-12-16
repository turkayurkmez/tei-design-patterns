// See https://aka.ms/new-console-template for more information
using Encapsulation;

Console.WriteLine("Hello, World!");
Console.WriteLine("Yaşınızı girin");

int age = Convert.ToInt32(Console.ReadLine());

//if (age < 0)
//{
//    throw new Exception("Yaşınız negatif olamaz");
//}
Person person = new Person();
//person.Age = age;

//Console.WriteLine("Yaşınız: " + person.Age);

person.SetAge(age);
Console.WriteLine(person.GetAge());
person.Name = "Kerem";

person.Salary = 5.3m;
