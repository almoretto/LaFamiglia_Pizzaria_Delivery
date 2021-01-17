using Entities.Enums;
using Entities.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Products
{
    public class Additional : Entity
    {
        
        public string Remark { get; set; }
        public Decimal Price { get; set; }
        public Status AdditionalStatus { get; set; }
        public DateTime LastChangeDate { get; set; }
        public int LastChangeUserId { get; set; }

        public Additional(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public Additional() { }
    }
}
