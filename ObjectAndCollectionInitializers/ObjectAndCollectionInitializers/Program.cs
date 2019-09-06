using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectAndCollectionInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Old Style of Object and Collection Initializers

            var customer = new Customer();
            customer.Name = "Phani";
            customer.Address = "UK";
            var item1 = new OrderItem();
            item1.ItemId = "a123";
            item1.Quantity = 5;
            var item2 = new OrderItem();
            item2.ItemId = "b456";
            item2.Quantity = 2;
            var order = new Order();
            order.OrderId = "xyz";
            order.Customer = customer;
            order.Items.Add(item1);
            order.Items.Add(item2);



            //New Style of Object and Collection Initializers

            var newOrder = new Order
            {
                OrderId = "xyz",
                Customer = new Customer { Name = "Phani", Address = "UK" },
                Items =
                {
                    new OrderItem { ItemId = "a123", Quantity = 5 },
                    new OrderItem { ItemId = "b456", Quantity = 2 }
                }
            };
        }
    }
}
