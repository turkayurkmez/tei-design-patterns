// See https://aka.ms/new-console-template for more information
using Strategy;

Console.WriteLine("Hello, World!");

/*
 * Bir operasyon için gereken algoritma, gelecekte değişirse (başka bir algoritma devreye girerse) bu değişikliği en ideal nasıl yönetirsiniz?
 * 
 * 
 */

CustomCollection custom = new CustomCollection (new BubbleSort());
CustomCollection c2 = new CustomCollection(new HeapSort());
//custom.Sort(new BubbleSort());
//custom.Sort(new HeapSort());

Console.WriteLine("sıralandı....");