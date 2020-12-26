using DataContext.People;
using Entities.People;
using System.Collections.Generic;

namespace BusinessRules.People
{
    public class AddressBus
    {
        private readonly SvcAddressDb _svcAddressDb;
        
        public AddressBus() { _svcAddressDb = new SvcAddressDb(); }
        
        public List<Address> FindByClientId(int clientId)
        { return _svcAddressDb.FindByClientId(clientId); }

        public int FindNextCode() 
        { return _svcAddressDb.FindNextCode(); }
    }
}
