using Entities.Enums;
using System;
using System.Collections.Generic;

namespace Entities.People
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long? Phone { get; set; }
        public long? CellPhone { get; set; }
        public Status Status { get; set; }
        public DateTime LastChangeDateTime { get; set; }
        public int LastChangeUserId { get; set; }
        public List<Address> Addresses { get; set; }

        public Client()
        {
            Addresses = new List<Address>();
        }
    }
}
