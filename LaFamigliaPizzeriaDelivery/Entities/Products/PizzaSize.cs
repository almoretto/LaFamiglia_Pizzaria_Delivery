using Entities.Enums;
using System;

namespace Entities.Products
{
    public class PizzaSize : Entity
    {
        public int FlvorsQty { get; set; }
        public string SizeRemark { get; set; }
        public double AdditionalPrice { get; set; }
        public Status SizeStatus { get; set; }
        public DateTime LastChangeDate { get; set; }
        public int LastChangeUserId { get; set; }

        public PizzaSize() { }
        public PizzaSize(int id, string description)
        {
            Id = id;
            Description = description;
        }
    }
}
