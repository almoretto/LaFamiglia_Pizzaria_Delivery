using DataContext.People;
using Entities.People;
using Entities.Views;
using System.Collections.Generic;

namespace BusinessRules.People
{
    public class AddressBus
    {
        private readonly SvcAddressDb _svcAddressDb;

        public AddressBus() { _svcAddressDb = new SvcAddressDb(); }

        public List<Address> FindByClientId(int clientId)
        { return _svcAddressDb.FindByClientId(clientId); }

        public Address FindAddressById(int addressId)
        { return _svcAddressDb.FindAddressById(addressId); }

        public List<EntityViewSearch> GetEntityViewSearch(int idClient)
        { return _svcAddressDb.GetEntityViewSearch(idClient); }

        public int FindNextCode()
        { return _svcAddressDb.FindNextCode(); }
    }
}
