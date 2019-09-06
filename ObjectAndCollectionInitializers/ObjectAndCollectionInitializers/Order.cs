using System.Collections.Generic;

namespace ObjectAndCollectionInitializers
{
    internal class Order
    {
        public Customer Customer { get; set; }
        public List<OrderItem> Items { get; set; }
        public string OrderId { get; set; }
    }
}