using Entities.People;

namespace Entities.System
{
    public class Session
    {
        private static Session UserSessionInstance;

        public static Entity User { get; set; }
        public static UserType UserType { get; set; }

        public static Session GetUserSessionInstance
        {
            get
            {
                if (UserSessionInstance==null)
                {
                    UserSessionInstance = new Session();
                }
                return UserSessionInstance;
            }
        }
    }
}

