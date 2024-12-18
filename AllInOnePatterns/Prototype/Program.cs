// See https://aka.ms/new-console-template for more information
using Prototype;
using System.Diagnostics;

Console.WriteLine("Hello, World!");
/*
 * Prototype Pattern
 * Problem:
 *   Bir nesneyi oluştuturken,  Constructor içerisinde uzun süren (zaman veya maliyet) işlemler bulunuyor.
 *   Bu maliyeti en aza nasıl indirebiliriz? *   
 *   
 */

string[] items = { "item1", "item2", "item3" };
var cloneOfItems = items.Clone() as string[];


string name = "TEİ";

 var nameClone = (string) name.Clone();
nameClone.Replace("E", "A");


//show all items in array function:
void ShowItems(string[] items)
{
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}


Console.WriteLine("Original Items:");
ShowItems(items);
Console.WriteLine("Cloned Items:");
ShowItems(cloneOfItems);

ImageCreator first = new ImageCreator();




for (int i = 0; i < 1000; i++)
{
    var image = first.Clone() as ImageCreator;
    image.Width = 100+i;
    image.Height = 100+i;
    foreach (var dict in image.ImageSettings)
    {
        Console.WriteLine($"Key: {dict.Key}, Value: {dict.Value.Value}");
    }

    Console.WriteLine($"Image {i} oluşturuldu: {DateTime.Now}");
    Console.WriteLine($"Resim boyutarı: En {image.Width} Boy: {image.Height}");
}

