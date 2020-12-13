using DataContext.People;
using Entities.People;
using System.Collections.Generic;

namespace BusinessRules.People
{
    public class UserBus
    {
        private readonly SvcUsersDb _svcUsersDb;
        public UserBus() { _svcUsersDb = new SvcUsersDb(); }
        public List<User> GetUsers() { return _svcUsersDb.GetUsers(); }
    }
}
