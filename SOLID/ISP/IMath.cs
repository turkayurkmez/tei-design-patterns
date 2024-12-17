using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public interface IRepository<T>
    {

        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();

      

    }

    public interface ISearchable<T>
    {
        IEnumerable<T> Search(string term);
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public decimal Total { get; set; }
    }

    public class ProductRepository : IRepository<Product>, ISearchable<Product>
    {
        public void Add(Product entity)
        {
            Console.WriteLine(entity.Name + " eklendi") ;
        }

        public void Delete(Product entity)
        {

            Console.WriteLine(entity.Name + " silindi");


        }

        public IEnumerable<Product> GetAll()
        {


            return Enumerable.Empty<Product>();
         
        }

        public Product GetById(int id)
        {

            return new Product();
        }

        public IEnumerable<Product> Search(string term)
        {
            Console.WriteLine($"{term} ismine göre arama yapılıyor.");
           return Enumerable.Empty<Product>();
        }

        public void Update(Product entity)
        {

            Console.WriteLine(entity.Name + " güncellendi");
        }
    }


  
    public class OrderRepository: IRepository<Order>
    {
        public void Add(Order entity)
        {
            Console.WriteLine(entity.OrderNumber + " eklendi");
        }
        public void Delete(Order entity)
        {
            Console.WriteLine(entity.OrderNumber + " silindi");
        }
        public IEnumerable<Order> GetAll()
        {
            return Enumerable.Empty<Order>();
        }
        public Order GetById(int id)
        {
            return new Order();
        }
        public void Update(Order entity)
        {
            Console.WriteLine(entity.OrderNumber + " güncellendi");
        }
    }
}
