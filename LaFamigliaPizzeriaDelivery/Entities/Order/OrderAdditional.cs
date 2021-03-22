using Entities.Products;

namespace Entities.Order
{
    public class OrderAdditional
    {
        public int Id { get; set; }
        public PizzaOrder PizzaOrder { get; set; } = new PizzaOrder();
        public Additional Additional { get; set; } = new Additional();
        public int AdditionalQty { get; set; }
        public double AdditionalAmount { get; private set; }

        public OrderAdditional() { }

        public OrderAdditional(PizzaOrder pizzaOrder, Additional additional, 
            int additionalQty, double additionalAmount)
        {
            PizzaOrder = pizzaOrder;
            Additional = additional;
            AdditionalQty = additionalQty;
            AdditionalAmount = 0.0d;
        }

        public bool SetAdditionalAmount(double amount)
        {
            AdditionalAmount = amount;
            if (AdditionalAmount>0.0)
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
