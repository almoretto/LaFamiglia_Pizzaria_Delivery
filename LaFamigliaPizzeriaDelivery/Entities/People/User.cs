using Entities.Enums;
using System;

namespace Entities.People
{
    public class User
    {
        public int Id { get; set; }
        public UserType UserType { get; set; }
        public string  Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Status UserStatus { get; set; }
        public DateTime LastChangeDate { get; set; }
        public int LastChangeUserId { get; set; }

        public User(){}
        public User(int id, UserType userType, string name, string login, string password, 
            Status userStatus, DateTime lastChangeDate, int lastChangeUserId)
        {
            Id = id;
            UserType = userType;
            Name = name;
            Login = login;
            Password = password;
            UserStatus = userStatus;
            LastChangeDate = lastChangeDate;
            LastChangeUserId = lastChangeUserId;
        }
    }
}
