﻿using DataContext.People;
using Entities.People;

namespace BusinessRules.People
{
    public class UserTypeBus
    {
        private readonly SvcUserTypeDb _svcUserTypeDb;
        public UserTypeBus() { _svcUserTypeDb = new SvcUserTypeDb(); }
        public UserType GetUserType(int id) { return _svcUserTypeDb.GetUserType(id); }
    }
}