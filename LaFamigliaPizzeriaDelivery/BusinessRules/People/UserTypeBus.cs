using DataContext.People;
using Entities.People;
using Entities.Views;
using System.Collections.Generic;

namespace BusinessRules.People
{
    public class UserTypeBus
    {
        private readonly SvcUserTypeDb _svcUserTypeDb;

        public UserTypeBus() { _svcUserTypeDb = new SvcUserTypeDb(); }

        public UserType GetUserType(int id) 
        { return _svcUserTypeDb.GetUserType(id); }

        public UserType GetUserTypeById(int id) 
        { return _svcUserTypeDb.GetUserTypeById(id); }

        public List<EntityViewSearch> GetEntityViewSearch()
        { return _svcUserTypeDb.GetEntityViewSearch(); }
    }
}
