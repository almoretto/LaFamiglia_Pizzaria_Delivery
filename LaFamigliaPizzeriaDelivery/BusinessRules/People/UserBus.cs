using DataContext.People;
using Entities.Enums;
using Entities.People;
using Entities.Views;
using System.Collections.Generic;

namespace BusinessRules.People
{
    public class UserBus
    {
        private readonly SvcUsersDb _svcUsersDb;
        public UserBus() { _svcUsersDb = new SvcUsersDb(); }

        public List<EntityViewSearch> GetEntityViewSearch(Status status)
        { return _svcUsersDb.GetEntityViewSearch(status); }
        public List<User> GetActiveUsers()
        { return _svcUsersDb.GetActiveUsers(); }
        public User FindById(int id)
        { return _svcUsersDb.FindById(id); }

    }
}
