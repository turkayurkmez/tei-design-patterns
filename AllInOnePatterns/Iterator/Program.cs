/*
 * Problem: Bellekte bulunan bir koleksiyonla belirli  bir algoritmayla (arama, parsing, dönüştürme vs) çalışmak istersem (ileri, geri, sona git, başa dön vs)
 * iterator kullanırım (siz kullanmazsanız, .NET kesin kullanılır)
 */

Iterator.Iterator designPattern = new Iterator.Iterator();

designPattern.Add("A");
designPattern.Add("B");
designPattern.Add("C");

var first = designPattern.First();
Console.WriteLine(first);
if (designPattern.MoveNext())
{
    Console.WriteLine($"{designPattern.Current}");
}

var second = designPattern.Next();
Console.WriteLine(second);
Console.WriteLine(designPattern.Current);
