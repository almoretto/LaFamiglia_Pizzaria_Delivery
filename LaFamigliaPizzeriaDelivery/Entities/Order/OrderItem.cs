using Entities.Products;

namespace Entities.Order
{
    public class OrderItem
    {
        public int Id { get; set; }
        public PizzaOrder PizzaOrder { get; set; } = new PizzaOrder();
        public PizzaSize Size { get; set; } = new PizzaSize();
        public PizzaEdgeFilling Edge { get; private set; } = null;
        public double ItemAmount { get; set; }

        public OrderItem() { }

        public OrderItem(PizzaOrder pizzaOrder, PizzaSize size, double amount)
        {
            PizzaOrder = pizzaOrder;
            Size = size;
            ItemAmount = amount;
        }

        public bool SetEdge(PizzaEdgeFilling edge)
        {
            Edge = edge;
            if (Edge!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
