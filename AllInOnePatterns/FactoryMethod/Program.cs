// See https://aka.ms/new-console-template for more information
using FactoryMethod;
using System.Data;

Console.WriteLine("Hello, World!");

//Problem:

/*
 * Düşünün ki bir havacılık firmasında çalışıyorsunuz ve uçak parçaları üreten fabrika için yazılım geliştiriyorsunuz.
 * Bu fabrikada, farklı tipte uçak motorları üretiliyor ve her motor tipi için  farklı bir test süreci uygulanıyor.
 * 
 * İkinci senaryo:
 *   Bir mobil turist rehberi geliştiriyorsunuz. Bu uygulama, kullanıcıların konumlarına göre yakındaki turistik yerleri gösteriyor.
 *   -- İnanç (camii, kilise, sinagog, vs.)
 *   -- Sanat (müze, galeri, vs.)
 *   -- Tarih (tarihi bina, anıt, vs.)
 *   -- Eğlence (sinema, tiyatro, vs.)
 *   
 *   Turist, inanç turu seçtiğinde, uygulama yakındaki camileri, kiliseleri, sinagogları göstermeli
 *    veya sanat turu seçtiğinde, müzeleri, galerileri göstermeli.
 *    
 *    
 *  Factory Method ne zaman kullanılır?
 *  
 *  1. Bir nesnenin nasıl oluşturulacağını bilmek istemiyorsanız.
 *  2. Alt sınıfların hangi nesneleri oluşturacağını karar vermesini istiyorsanız.
 *  3. Nesne oluşturma işlemlerini merkezi bir noktada toplamak istiyorsanız.
 *  
 * 
 */





try
{
	EngineTestFactory factory = new AircraftEngineTestFactory();
	var testReport = factory.ExecuteEngineTest(EngineTypes.Military);
    Console.WriteLine($"Test Raporu:");
    Console.WriteLine($"TestId: {testReport.TestId}");
    Console.WriteLine($"TestDate: {testReport.TestDate}");
    Console.WriteLine($"EngineType: {testReport.EngineType}");

  
    testReport = factory.ExecuteEngineTest(EngineTypes.Commercial);
    Console.WriteLine($"Test Raporu:");
    Console.WriteLine($"TestId: {testReport.TestId}");
    Console.WriteLine($"TestDate: {testReport.TestDate}");
    Console.WriteLine($"EngineType: {testReport.EngineType}");

    testReport = factory.ExecuteEngineTest(EngineTypes.Drone);
    Console.WriteLine($"Test Raporu:");
    Console.WriteLine($"TestId: {testReport.TestId}");
    Console.WriteLine($"TestDate: {testReport.TestDate}");
    Console.WriteLine($"EngineType: {testReport.EngineType}");


    testReport = factory.ExecuteEngineTest(EngineTypes.Civil);
    Console.WriteLine($"Test Raporu:");
    Console.WriteLine($"TestId: {testReport.TestId}");
    Console.WriteLine($"TestDate: {testReport.TestDate}");
    Console.WriteLine($"EngineType: {testReport.EngineType}");



}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}

public class EngineTypes
{
    public const string Military = "military";
    public const string Commercial = "commercial";
    public const string Drone = "drone";
    public const string Civil = "civil";
}