using Entities.Enums;

namespace Entities.Views
{
    public class EntityViewProducts : Entity
    {
        public Status Status { get; set; }
        public double Price { get; set; }

        public EntityViewProducts() { }

        public EntityViewProducts(Status status, double price)
        {
            Status = status;
            Price = price;
        }
    }
}
