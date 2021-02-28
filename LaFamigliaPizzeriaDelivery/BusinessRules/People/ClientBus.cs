using DataContext.People;
using Entities.Enums;
using Entities.People;
using Entities.Views;
using System.Collections.Generic;

namespace BusinessRules.People
{
    public class ClientBus
    {
        private readonly SvcClientDb _svcClientDb;

        public ClientBus()
        { _svcClientDb = new SvcClientDb(); }

        public List<EntityViewClient> GetEntityViewClient(Status status, string term)
        { return _svcClientDb.GetEntityViewClient(status, term); }

        public Client FindClientFullEntity(int id)
        { return _svcClientDb.FindClientFullEntity(id); }

        public Client FindClientByContact(long contact)
        { return _svcClientDb.FindClientByContact(contact); }

        public Client FindClientById(int id)
        { return _svcClientDb.FindClientById(id); }

        public int FindNextCode()
        { return _svcClientDb.FindNextCode(); }

        public bool CreateClient(Client clientToCreate)
        { return _svcClientDb.CreateClient(clientToCreate); }

        public bool EditClient(Client clientToEdit)
        { return _svcClientDb.EditClient(clientToEdit); }

        public bool DeleteClient(Client clientToDelete)
        { return _svcClientDb.DeleteClient(clientToDelete); }
    }
}
