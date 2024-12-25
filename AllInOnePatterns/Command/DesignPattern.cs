using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    //1. Tüm komutları bir interface'den implemente et.

    public interface ICommand
    {
        int Id { get; set; }
        void Execute();

    }

    //2. Komutlar, kategorik olarak nerede değerlendirilecekler?
    public class DbCommandReceiver
    {
        public void CreateNewProduct(string name, decimal price) => Console.WriteLine($" {name} isimli yeni Ürün Eklendi");

        public void DiscountProductPrice(int id, decimal discountRate) => Console.WriteLine($"{id} id'li ürünün fiyat indirildi");

        //Dikkat! Database ilgili tüm komutların eylem noktası (son durak) burasıdır. Burada sisteminizin db'le olan tüm eylemleri olabilir. Elbette bir fonksiyon yerine bir class ile de çözülebilir (Bu ancak başka bir patern'i de zorunlu kılar.)


    }
    //3. Artık komutlarınızı tasarlayınız.

    public class CreateNewProductCommand : ICommand
    {


        //Her command, kendisini değerlendirecek olan Receiver ile çalışır. 
        //Seni, kimler değerlendirecek?
        DbCommandReceiver receiver;

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Id { get; set; }

        public CreateNewProductCommand(DbCommandReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            receiver.CreateNewProduct(Name, Price);
        }
    }

    public class DiscountProductCommand : ICommand
    {
        public DbCommandReceiver receiver;
        public int Id { get; set; }

        public int ProductId { get; set; }
        public decimal Price { get; set; }

        public DiscountProductCommand(DbCommandReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            receiver.DiscountProductPrice(ProductId, Price);
        }

    }


    //4. Komutlarınızı sırayla çalıştırma, iptal etme veya müdahale etme için Invoker sınıfınız:

    public class CommandInvoker
    {
        //Bu nesne, hangi komutların nerede çalıştığını BİLEMEZ!
        private Queue<ICommand> commands = new();
        public void Add(ICommand command) => commands.Enqueue(command);
        public void Clear() => commands.Clear();
        public void RemoveCommand(ICommand command)
        {
            commands = new Queue<ICommand>(commands.Where(c => c != command));
            //commands.ToList().Remove(command);
        }
        public void RemoveCommand(int id)
        {
            var command = commands.ToList().FirstOrDefault(x => x.Id == id);
            commands.ToList().Remove(command);
        }

        public void ExecuteCommands()
        {
            while (commands.Count > 0)
            {
                var command = commands.Dequeue();
                command.Execute();
            }
        }

    }

}
