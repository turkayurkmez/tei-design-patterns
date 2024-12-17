// See https://aka.ms/new-console-template for more information
using LSP;

Console.WriteLine("Hello, World!");

//Barbara Liskov'a göre; Bir sınıftan türeyen al sınıflar, birbirleriyle yer değiştitirilebiliyor olmalıdır.
//Bu formüle göre miras ilişkisi kurulmalıdır.
//Bir alt sınıf, üst sınıfın davranışlarını değiştirmemelidir.



Square square1 = new Square { EdgeLength = 5 };
Console.WriteLine("Kare " + square1.GetArea());

Rectangle rectangle = new Rectangle { Width = 5, Height = 10 };
Console.WriteLine("Dikdörtgen: " + rectangle.GetArea());



//var rect = new Geometry().GetRectangle();
//rect.Width = 5;
//rect.Height = 10;
//Console.WriteLine("Dikdörtgen: " + rect.GetArea());

var rectange = new Geometry().GetRectangle(5, 10);
Console.WriteLine("Dikdörtgen: " + rectange.GetArea());

var square = new Geometry().GetRectangle(5);
Console.WriteLine("Kare: " + square.GetArea());


