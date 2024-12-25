// See https://aka.ms/new-console-template for more information
/*
 * Problem:
 * 
 *   Güvenlik, Maaliyet (Parasal veya Performans :) ) gibi sebeplerden dolayı kritik bir nesneye doğrudan erişmek istemiyorsunuz. Bu erişimi nasıl denetlersiniz?
 */

using Proxy;

ProxyMath proxyMath = new ProxyMath();
for (int i = 0; i < 100; i++)
{

	try
	{
		var output = proxyMath.Add(3, 5);
        Console.WriteLine(output.ToString());
    }
	catch (InvalidOperationException ex)
	{

        Console.WriteLine(ex.Message);
	}
   
}
