using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Products
{
    public class PizzaFlavor : Entity
    {
        public string FlavorRemark { get; set; }
        public double AdditionalPrice { get; set; }
        public Status FlavorStatus { get; set; }
        public DateTime LastChangeDate { get; set; }
        public int LastChangeUserId { get; set; }

        public PizzaFlavor(){}
        public PizzaFlavor(int id, string description)
        {
            Id = id;
            Description = description;
        }
    }
}
