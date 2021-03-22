using Entities.Products;
using System.Collections.Generic;

namespace Entities.Order
{
    public class OrderPizzaFlavors
    {
        public int Id { get; set; }
        public OrderItem OrderItem { get; set; }
        public List<PizzaFlavor> Flavors { get; set; }

        public OrderPizzaFlavors() { }

        public OrderPizzaFlavors(OrderItem orderItem, List<PizzaFlavor> flavors)
        {
            OrderItem = orderItem;
            Flavors = flavors;
        }
    }
}
