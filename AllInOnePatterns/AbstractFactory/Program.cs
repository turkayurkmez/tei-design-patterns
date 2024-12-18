// See https://aka.ms/new-console-template for more information
/*
    
          Siyah                   Cam              Metal
        Çorba Kasesi          Çorba Kasesi        Çorba Kasesi
        Yemek Tabağı          Yemek Tabağı        Yemek Tabağı
        Salata Kasesi         Salata Kasesi       Salata Kasesi


          Postgresql              SqlServer              Oracle
       PostgreSqlConnection
       PostgreSqlCommand
       PostgreSqlDataReader
 

Bu Abstract Factory ne zaman kullanılır?

 1. Birbirleriyle ilişkili nesne ailesi oluşturmak istediğinizde.
 2. Sistem bağımsızlığı elde etmek istediğinizde.
 3. Tutarlılık gerektiren durumlar: 
 4. Test edilebilirlik
 5. Ürün Ailesini versiyonlamak istediğinizde.
 
 */

using AbstractFactory;

DbManager dbManager = new DbManager(new PostgreSqlFactory());
dbManager.Execute("Select * from Customers");


dbManager = new DbManager(new MicrosoftSqlServerFactory());
dbManager.Execute("Select * from Customers");


