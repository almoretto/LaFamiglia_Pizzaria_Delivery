using Entities.Enums;
using System;

namespace Entities.Products
{
    public class PizzaEdgeFilling: Entity
    {
        public string EdgeRemark { get; set; }
        public double AdditionalPrice { get; set; }
        public Status EdgeStatus { get; set; }
        public DateTime LastChangeDate { get; set; }
        public int LastChangeUserId { get; set; }

        public PizzaEdgeFilling() { }
        public PizzaEdgeFilling(int id, string description)
        {
            Id = id;
            Description = description;
        }

    }
}

    