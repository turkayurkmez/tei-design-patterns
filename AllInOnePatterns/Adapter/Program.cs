// See https://aka.ms/new-console-template for more information
using Adapter;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");
/*
 * Adapter Pattern
 * 
 * Problem:
 * 
 *   Uygulamanız dışında kullanılan (3rd party) bileşenlerin birbirlerine uyum sağlayacak biçimde data paylaşmak istiyorsanız, adapter pattern kullanabilirsiniz.
 *   
 *   
 */

DataReaderComponent dataReaderComponent = new DataReaderComponent();
var jsonList =dataReaderComponent.ReadData(new JsonDataProcessor());
var xmlList = dataReaderComponent.ReadData(new XmlDataProcessor());   


jsonList.ToList().ForEach(x => Console.WriteLine(x));
xmlList.ToList().ForEach(x => Console.WriteLine(x));



