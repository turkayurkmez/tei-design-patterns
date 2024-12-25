using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    /*
     * Bir sipariş transaction yönetimi
     */
    public class Customer
    {
        public string Name { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }

    }

    public class Order
    {
        public int Id { get; set; }

        public Customer Customer { get; set; }
        public DateOnly OrderDate { get; set; }

        public List<OrderItem> OrderItems { get; set; }


    }
    public class OrderItem
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public Product Product { get; set; } = new Product ();

    }

    //İşte facade sınıfı:
    public class OrderService
    {
        public void CreateOrder(Customer customer, List<OrderItem> orderItems)
        {
            Order order = new Order() { OrderDate = new DateOnly(2024,12,23)};
            order.Customer = customer;
            order.OrderItems = new List<OrderItem>();

            orderItems.ForEach(oi=>
            {
                order.OrderItems.Add(oi);
                Console.WriteLine($"{customer.Name} isimli müşteri, {order.OrderDate} tarihinde { oi.Product.Name } ürünü satın alındı");
                Console.WriteLine($"ürün stoğundan {oi.Quantity} adet düşüldü");
            });

            //db işlemleri bitti.

        }
    }


}