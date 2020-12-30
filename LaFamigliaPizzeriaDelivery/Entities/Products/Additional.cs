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
        public double Price { get; set; }
        public Status AdditionalStatus { get; set; }
        public DateTime LastChangeDate { get; set; }
        public User LastChangeUser { get; set; }
        
        public Additional(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public Additional() { }
    }
}
